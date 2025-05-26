using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    public class Manager : ILead
    {
        public void AssginTask()
        {
            throw new NotImplementedException();
        }

        public void AssignTask()
        {
            //Code to assign a task.
        }
        public void CreateSubTask()
        {
            //Code to create a sub task.
        }
        public void WorkOnTask()
        {
            throw new Exception("Manager can't work on Task");
        }
    }

    public class Programmer : IProgrammer
    {
        public void WorkOnTask()
        {
            //code to implement to work on the Task.
        }
    }
    public class Manager : ILead
    {
        public void AssignTask()
        {
            //Code to assign a Task
        }
        public void CreateSubTask()
        {
            //Code to create a sub taks from a task.
        }
    }
}
