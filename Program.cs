using Abstract_Factory.Models.Bots;
using Abstract_Factory.Models.Engine;

namespace Abstract_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Engine engine = new();
            foreach(var obj in Enum.GetValues(typeof(BotsEnum)))
            {
                Console.WriteLine(obj);
                engine.CreateBot((BotsEnum)obj);
            }
            Console.ReadKey();
        }
    }
}