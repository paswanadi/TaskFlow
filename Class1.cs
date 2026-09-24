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
}