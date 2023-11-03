namespace DesignPatterns.Strategy.After
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Fly no way...");
        }
    }
}
