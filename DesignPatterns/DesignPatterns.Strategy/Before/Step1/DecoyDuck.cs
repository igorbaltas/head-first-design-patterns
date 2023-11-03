namespace DesignPatterns.Strategy.Before.Step1
{
    public class DecoyDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("DecoyDuck appears...");
        }

        public override void Quack()
        {
            Console.WriteLine("...");
        }

        public override void Fly()
        {
            Console.WriteLine("...");
        }
    }
}
