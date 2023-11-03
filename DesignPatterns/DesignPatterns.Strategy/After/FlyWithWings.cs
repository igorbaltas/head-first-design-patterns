namespace DesignPatterns.Strategy.After
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Fly with wings...");
        }
    }
}
