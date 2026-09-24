using TaskFlow;

namespace TaskFlow
{
    public abstract class MyTask
    {
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public abstract string GetInfo();
    }


    public class StudyTask : MyTask
    {
        public override string GetInfo()
        {
            return "Study: " + Title;
        }
    }

    public class WorkTask : MyTask
    {
        public override string GetInfo()
        {
            return "Work: " + Title;
        }
    }
}
