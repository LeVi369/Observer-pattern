namespace Observer
{
    public class ConcreteObserver : Observer
    {
        int count = 0;
        public int Count { get { return count; } }
        public void Update(Subject subject)
        {
            count++;
        }
    }
}