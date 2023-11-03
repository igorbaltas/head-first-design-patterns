namespace DesignPatterns.Strategy.After
{
    public class Quack : IQuackBehavior
    {
        void IQuackBehavior.Quack()
        {
            Console.WriteLine("Quack...");
        }
    }
}
