// See https://aka.ms/new-console-template for more information
using PatronesDiseno.Singleton;

namespace PatronesDiseno
{
    class Program
    {
        static void Main(string[] args)
        {
            var log = Singleton.Log.Instance;

            log.Save("Prueba");
        }
    }
}

