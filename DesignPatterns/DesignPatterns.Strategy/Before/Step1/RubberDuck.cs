namespace DesignPatterns.Strategy.Before.Step1
{
    public class RubberDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("RubberDuck appears...");
        }

        public override void Quack()
        {
            Console.WriteLine("Squeak...");
        }

        public override void Fly()
        {
            Console.WriteLine("...");
        }
    }
}
