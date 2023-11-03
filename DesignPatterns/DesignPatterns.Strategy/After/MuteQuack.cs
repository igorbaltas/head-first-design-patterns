namespace DesignPatterns.Strategy.After
{
    public class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("MuteQuack...");
        }
    }
}
