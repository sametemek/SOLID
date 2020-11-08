using System;

namespace ISP
{
    public interface ILead
    {
        void CreateSubTask();
        void AssignTask();
        void WorkOnTask();
    }
    public class TeamLead : ILead
    {
        public void AssignTask()
        {
            //Code to assign a task.  
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
