using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace remote_csgo
{
    public static class TaskManager
    {

        public static List<TaskScriptObject> TaskList = new List<TaskScriptObject>();

        public static bool RunScript = false;
        public static void InsertTask(TaskScriptObject Task) {
            TaskList.Add(Task);
        }
        public static void ClearTasks()
        {
            TaskList.Clear();
        }

        public static void RunTaskManager()
        {
            while (true)
            {
                if (RunScript)
                {
                    foreach (TaskScriptObject Task in TaskList)
                    {
                        Task.DoTask();
                    }
                }
                Thread.Sleep(10);
            }
        }
    }
}
