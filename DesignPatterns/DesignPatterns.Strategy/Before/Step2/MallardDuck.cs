namespace DesignPatterns.Strategy.Before.Step2
{
    public class MallardDuck : Duck, IFlyable, IQuackable
    {
        public override void Display()
        {
            Console.WriteLine("MallardDuck appears...");
        }

        public void Fly()
        {
            Console.WriteLine("Flying...");
        }

        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
