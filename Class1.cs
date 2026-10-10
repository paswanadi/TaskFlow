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
            return "Study";
        }
    }

    public class WorkTask : MyTask
    {
        public override string GetInfo()
        {
            return "Work";
        }
    }

    public class WorkoutTask : MyTask
    {
        public override string GetInfo()
        {
            return "Workout";
        }
    }

    public class MovieTask : MyTask
    {
        public override string GetInfo()
        {
            return "Movies";
        }
    }

    public class Dummy : MyTask 
    {
        public override string GetInfo()
        {
            return "Dummy";
        }
    }
}