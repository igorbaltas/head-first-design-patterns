namespace DesignPatterns.Strategy.Before.Step2
{
    public class RedHeadDuck : Duck, IFlyable, IQuackable
    {
        public override void Display()
        {
            Console.WriteLine("RedHeadDuck appears...");
        }

        public void Fly()
        {
            Console.WriteLine("Fly...");
        }

        public void Quack()
        {
            Console.WriteLine("Quack...");
        }
    }
}
