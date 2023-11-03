namespace DesignPatterns.Strategy.Before.Step2
{
    public class RubberDuck : Duck, IQuackable
    {
        public override void Display()
        {
            Console.WriteLine("RubberDuck appears...");
        }

        public void Quack()
        {
            Console.WriteLine("Quack...");
        }
    }
}
