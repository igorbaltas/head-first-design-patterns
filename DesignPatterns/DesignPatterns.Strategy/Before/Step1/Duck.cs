namespace DesignPatterns.Strategy.Before.Step1
{
    public abstract class Duck
    {
        public abstract void Display();
        public virtual void Quack()
        {
            Console.WriteLine("Quack...");
        }

        public virtual void Swim()
        {
            Console.WriteLine("Swim...");
        }

        public virtual void Fly()
        {
            Console.WriteLine("Fly...");
        }
    }
}
