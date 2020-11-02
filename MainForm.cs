using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace remote_csgo
{
    public partial class MainForm : Form
    {
        public static RichTextBox VirtCon;
        public MainForm()
        {
            InitializeComponent();
            TextBox.CheckForIllegalCrossThreadCalls = false;
            VirtCon = VirtualConsoleBox;
            // MessageBox.Show(NetScanManager.IsPortOpen("127.0.0.1", 8887).ToString());
            Thread ScanTimer = new Thread(DoScan);
            ScanTimer.SetApartmentState(ApartmentState.STA);
            ScanTimer.Start();
        }


        public void ScrollConsole()
        {
            VirtualConsoleBox.SelectionStart = VirtualConsoleBox.Text.Length;
            VirtualConsoleBox.ScrollToCaret();
        }

        public List<CsgoListenerObject> ListenerList = new List<CsgoListenerObject>();

        public static bool ShouldFilterSelected = false;
        public static CsgoListenerObject FilterSelected = null;
        public static void AppendConsoleThread(CsgoListenerObject  Sender, string Text)
        {
            bool ShouldDisplay = false;
            if (ShouldFilterSelected)
            {
                if (FilterSelected != null)
                {
                    if (Sender.Hostname == FilterSelected.Hostname && Sender.Port == FilterSelected.Port)
                    {
                        ShouldDisplay = true;
                    }
                }
            }
            else
            {
                ShouldDisplay = true;
            }

            if (ShouldDisplay)
            {
                if (VirtCon.InvokeRequired)
                {
                    VirtCon.Invoke((MethodInvoker)delegate
                    {
                        VirtCon.AppendText("[" + Sender.ToString() + "]" + Text + "\n");
                        VirtCon.SelectionStart = VirtCon.Text.Length;
                        VirtCon.ScrollToCaret();
                    });
                }
            }
           
        }

        public void AppendConsoleNormally(string Text)
        {
            ScrollConsole();
        }


        public List<ScanObject> ScanList = new List<ScanObject>();
        public bool DoingScan = false;
        private void DoScanButton_Click(object sender, EventArgs e)
        {
            string Hostname = HostNameBox.Text;
            if (Hostname != "")
            {
                int PortLow = (int)PortLowBox.Value;
                int PortHigh = (int)PortUpBox.Value;

                int Count = 0;
                for (int i = PortLow; i < PortHigh; i++)
                {
                    ScanList.Add(new ScanObject(Hostname, i));
                    Console.WriteLine(i);
                }

                int Left = PortHigh - PortLow;
                ScanStatusLabel.Text = "Scan left: " + Left;
                DoingScan = true;
                
            }
           // ScanTimer.Start();
        }

        private void PortLowBox_ValueChanged(object sender, EventArgs e)
        {
            if (PortLowBox.Value >= PortUpBox.Value)
            {
                PortLowBox.Value--;
            }

        }

        private void PortUpBox_ValueChanged(object sender, EventArgs e)
        {
            if (PortUpBox.Value <= PortLowBox.Value)
            {
                PortUpBox.Value++;
            }
        }


        


        private void DoScan()
        {
            while (true)
            {
                if (ScanList.Count >= 1)
                {
                    ScanObject CurScan = ScanList[0];
                    bool IsOpen = NetScanManager.IsPortOpen(CurScan.Hostname, CurScan.Port);
                    Console.WriteLine("The " + CurScan.Port + " Is" + IsOpen.ToString());
                    if (IsOpen)
                    {
                        ScanResultBox.Items.Add(CurScan);
                    }
                    ScanList.RemoveAt(0);
                    ScanStatusLabel.Text = "Scan left: " + ScanList.Count;
                }

                if (ScanList.Count == 0)
                {
                    if (DoingScan)
                    {
                        DoingScan = false;
                        MessageBox.Show("Scan complete!");
                        ScanStatusLabel.Text = "Scan left: 0";
                    }
                }
                Thread.Sleep(500);
            }
        }
        private void ScanTimer_Tick(object sender, EventArgs e)
        {
           
        }

        public void RefreshListenerListBox()
        {
            ListenerListBox.Items.Clear();
            foreach (CsgoListenerObject Listener in ListenerList)
            {
                ListenerListBox.Items.Add(Listener);
            }
        }

        public void AddNewListener(ScanObject Result)
        {
            CsgoListenerObject Listener = new CsgoListenerObject(Result);
            ListenerList.Add(Listener);
            RefreshListenerListBox();
        }
        private void AddResultButton_Click(object sender, EventArgs e)
        {
            if (ScanResultBox.SelectedItem != null)
            {
                ScanObject Selected = (ScanObject)ScanResultBox.SelectedItem;
                AddNewListener(Selected);
            }
        }

        private void AddAllButton_Click(object sender, EventArgs e)
        {
            foreach (object Obj in ScanResultBox.Items)
            {
                ScanObject ScanObj = (ScanObject)Obj;
                AddNewListener(ScanObj);
            }
        }


        public void RemoveAListenerFromList(CsgoListenerObject Listener)
        {
            for (int i =0; i < ListenerList.Count; i++)
            {
                CsgoListenerObject CsgoList = ListenerList[i];
                if (CsgoList.Hostname == Listener.Hostname && CsgoList.Port == Listener.Port)
                {
                    CsgoList.CloseConnection();
                    ListenerList.RemoveAt(i);
                }
            }

            RefreshListenerListBox();
        }
        private void RemoveAllCsgoButton_Click(object sender, EventArgs e)
        {
            for  (int i = 0; i< ListenerListBox.Items.Count; i++) 
            {
                CsgoListenerObject CsListen = (CsgoListenerObject)ListenerListBox.Items[i];
                RemoveAListenerFromList(CsListen);
            }
        }

        private void RemoveSelectedCsgo_Click(object sender, EventArgs e)
        {
            if (ListenerListBox.SelectedItem != null)
            {
                RemoveAListenerFromList((CsgoListenerObject)ListenerListBox.SelectedItem);
            }
        }

        private void CmdSelectedButton_Click(object sender, EventArgs e)
        {
            if (ListenerListBox.SelectedItem != null && VirtualConsoleRichTextBox.Text != "")
            {
                CsgoListenerObject Selected = (CsgoListenerObject)ListenerListBox.SelectedItem;
                string[] Lines = VirtualConsoleRichTextBox.Lines;
                foreach (string Line in Lines)
                {
                    AppendConsoleNormally("[Local] Sent command: " + Line);
                    Selected.SendMessage(Line);
                }
                

            }
        }

        private void CmdAllButton_Click(object sender, EventArgs e)
        {
            string[] Lines = VirtualConsoleRichTextBox.Lines;
            foreach (CsgoListenerObject Listener in ListenerList)
            {
                foreach (string Line in Lines)
                {
                    AppendConsoleNormally("[Local] Sent command: " + Line);
                    Listener.SendMessage(Line);
                }
            }
        }

        
        private void FilterSelectedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ShouldFilterSelected = FilterSelectedCheckBox.Checked;
        }

        private void ListenerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListenerListBox.SelectedItem != null)
            {
                FilterSelected = (CsgoListenerObject)ListenerListBox.SelectedItem;

            }
           
        }


        public void RefreshCfgButtons()
        {
            if (CfgFileLines.Length > 0)
            {
                RunCfgSelectedButton.Enabled = true;
                RunCfgAllButton.Enabled = true;
            }
            else
            {
                RunCfgSelectedButton.Enabled = false;
                RunCfgAllButton.Enabled = false;
            }
        }

        string[] CfgFileLines = null;
        private void LoadCFGButton_Click(object sender, EventArgs e)
        {
            CfgFileLines = FileManager.LoadCFG();
            MessageBox.Show("Loaded Configuration with " + CfgFileLines.Length + " Lines" );
            RefreshCfgButtons();
        }

        private void RunCfgSelectedButton_Click(object sender, EventArgs e)
        {
            if (FilterSelected != null)
            {
                foreach (string Line in CfgFileLines)
                {
                    AppendConsoleNormally("[Local] Sent command: " + Line);
                    FilterSelected.SendMessage(Line);
                }

                MessageBox.Show("Ran CFG On " + FilterSelected.ToString() + " successfully.");
            }
        }

        private void RunCfgAllButton_Click(object sender, EventArgs e)
        {
            foreach (CsgoListenerObject Listener in ListenerList)
            {
                foreach (string Line in CfgFileLines)
                {
                    AppendConsoleNormally("[Local] Sent command: " + Line);
                    Listener.SendMessage(Line);
                }
                MessageBox.Show("Ran CFG On all listeners successfully.");
            }
        }


        public int LoopDelay = 1000;
        bool CmdLoop = false;
        bool LoopCmdAll = false;
        bool LoopCmdSelected = false;

        private void LoopDelayUpDown_ValueChanged(object sender, EventArgs e)
        {
            LoopDelay = (int)LoopDelayUpDown.Value;
            CmdLoopTextBox.Interval = LoopDelay;
        }

        private void LoopCmdButton_CheckedChanged(object sender, EventArgs e)
        {
            CmdLoop = LoopCmdButton.Checked;
            if (CmdLoop)
            {
                if (!CmdLoopTextBox.Enabled)
                {
                    CmdLoopTextBox.Start();
                }
            }
        }

        private void CmdLoopTextBox_Tick(object sender, EventArgs e)
        {
            if (CmdLoop)
            {
                if (VirtualConsoleRichTextBox.Text != "")
                {
                    if (LoopCmdAll)
                    {
                        string[] Lines = VirtualConsoleRichTextBox.Lines;
                        foreach (CsgoListenerObject Listener in ListenerList)
                        {
                            foreach (string Line in Lines)
                            {
                                AppendConsoleNormally("[Local] Sent command: " + Line);
                                Listener.SendMessage(Line);
                            }
                        }
                    }

                    if (LoopCmdSelected && FilterSelected != null)
                    {
                        string[] Lines = VirtualConsoleRichTextBox.Lines;
                            foreach (string Line in Lines)
                            {
                                AppendConsoleNormally("[Local] Sent command: " + Line);
                                FilterSelected.SendMessage(Line);
                            }
                    }
                }
                
            }


        }

        private void LoopCmdAllButton_CheckedChanged(object sender, EventArgs e)
        {
            LoopCmdAll = LoopCmdAllButton.Checked;
            if (LoopCmdAll)
            {
                LoopCmdSelected = false;
                LoopCmdSelectedButton.Checked = false;
            }
        }

        private void LoopCmdSelectedButton_CheckedChanged(object sender, EventArgs e)
        {
            LoopCmdSelected = LoopCmdSelectedButton.Checked;
            if (LoopCmdSelected)
            {
                LoopCmdAll = false;
                LoopCmdAllButton.Checked = false;
            }
        }

        private void ClosedAPp(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }


        
        private void CmdMacrosButton_Click(object sender, EventArgs e)
        {

        }
    }
}
