namespace ejemplo_01.Services
{
    public class ServiceTransient
    {
        readonly string Id = Guid.NewGuid().ToString();

        public void Print()
        {
            Console.WriteLine($"Transient[ID  == >{Id}]");
        }
    }
}
