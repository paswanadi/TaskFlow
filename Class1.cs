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

    public class WorkoutTask : MyTask
    {
        public override string GetInfo()
        {
            return "Workout: " + Title;
        }
    }

    public class MovieTask : MyTask
    {
        public override string GetInfo()
        {
            return "Movie: " + Title;
        }
    }
}
