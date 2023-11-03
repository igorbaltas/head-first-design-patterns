namespace DesignPatterns.Strategy.Before.Step2
{
    public abstract class Duck
    {
        public abstract void Display();

        public virtual void Swim()
        {
            Console.WriteLine("Swim...");
        }
    }
}
