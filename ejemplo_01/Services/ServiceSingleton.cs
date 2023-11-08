namespace ejemplo_01.Services
{
    public class ServiceSingleton
    {
        readonly string Id = Guid.NewGuid().ToString();

        public void PrintSingleton()
        {
            Console.WriteLine($"Singleton[ID  == >{Id}]");
        }
    }
}
