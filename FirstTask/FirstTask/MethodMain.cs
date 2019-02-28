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
            var vectorCollections = new VectorCollections(args);
            Console.WriteLine($"view: {vectorCollections.ToString()}");
            int [,] collectionNumbers = vectorCollections.TransformNumber();
            
            int[] vectorResult = VectorCollectionOperations.Instance.RealizeOperation(collectionNumbers, VectorCollectionOperations.Operation.Sum);
            Console.WriteLine($"sum: {VectorCollectionOperations.Instance.TranformVectorToString(vectorResult)}");
            int[] vectorResult2 = VectorCollectionOperations.Instance.RealizeOperation(collectionNumbers, VectorCollectionOperations.Operation.Minus);
            Console.WriteLine($"minus: {VectorCollectionOperations.Instance.TranformVectorToString(vectorResult2)}");
        }
    }
}
