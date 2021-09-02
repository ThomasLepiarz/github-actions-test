using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
           Writetext("Tomek");

        }
        static void Writetext(string name) => Console.WriteLine($"Hello {name}");
    }
}