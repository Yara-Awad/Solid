using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    public interface ILead
    {
   void CreateSubTask();
   void AssginTask();
   void WorkOnTask();
    }
    public class TeamLead : ILead
    {
        public void AssginTask()
        {
            throw new NotImplementedException();
        }

      
        public void CreateSubTask()
        {
            //Code to create a sub task
        }
        public void WorkOnTask()
        {
            //Code to implement perform assigned task.
        }
    }
}
