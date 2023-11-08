namespace ejemplo_01.Services
{
    public class ServiceScope
    {
        readonly string Id = Guid.NewGuid().ToString();

        public void PrintScope()
        {
            Console.WriteLine($"Scope[ID  == >{Id}]");
        }
    }
}
