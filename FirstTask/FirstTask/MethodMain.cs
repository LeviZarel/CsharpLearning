using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    class MethodMain
    {
        static void Main(string[] args)
        {
          
            MagicVector vector = new MagicVector(args);
            Console.Write("Sum: ");
            vector.printVector(vector.Sum());
            Console.WriteLine("Matriz: ");
            vector.PrintMatriz();
        }
    }
}
