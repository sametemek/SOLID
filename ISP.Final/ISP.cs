using System;

namespace ISP.Final
{
    public interface IDeveloper
    {
        void WorkOnTask();
    }
    public interface ILead
    {
        void AssignTask();
        void CreateSubTask();
    }

    public class Developer : IDeveloper
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

    public class TeamLead : IDeveloper, ILead
    {
        public void AssignTask()
        {
            //Code to assign a Task  
        }
        public void CreateSubTask()
        {
            //Code to create a sub task from a task.  
        }
        public void WorkOnTask()
        {
            //code to implement to work on the Task.  
        }
    }
}
