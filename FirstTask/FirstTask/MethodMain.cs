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
            try
            {
                var vectorCollections = new VectorCollections(args);
                var vectorA = vectorCollections.getVectorByIndex(0);
                var vectorB = vectorCollections.getVectorByIndex(1);
                var vectorResultPlus = vectorA.Add(vectorB);
                Console.WriteLine($"Add: {vectorResultPlus.ToString()}");
                int vectorResultDot = vectorA.DotProduct(vectorB);
                Console.WriteLine($"Dot Product: {vectorResultDot}");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
