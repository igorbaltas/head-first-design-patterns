namespace DesignPatterns.Strategy.After
{
    public class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeak...");
        }
    }
}
