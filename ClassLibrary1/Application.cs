using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class Application
    {
        private Application application;
        private List<TaskList> taskList;
    }

    public Application()
    {
        TaskList taskList = new TaskList("Входящие");
        TaskLists = new List<TaskList>();
        taskList.Add(taskList);
    }

    public Application GetApplication()
    {
        if (application != null)
            return application

        application = new Application();
        return Application;
    }

    public void CreateTaskList(string name)
    {

    }
}
