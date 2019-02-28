using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    class VectorCollectionOperations
    {
        private static VectorCollectionOperations MyInstance = null;

        public enum Operation{ Sum, Minus, Plus};
        public static VectorCollectionOperations Instance
        {
            get
            {
                if (MyInstance == null)
                {
                    MyInstance = new VectorCollectionOperations();
                }
                return MyInstance;
            }
        }
        public int[] RealizeOperation(int [,] collectionsNumbers, Operation operation)
        {
            int rowLength = collectionsNumbers.GetLength(0);
            int colLength = collectionsNumbers.GetLength(1);
            int[] vectorResult = new int[colLength];
            for (int i = 0; i < colLength; i++)
            {
                vectorResult[i] = 0;
            }
            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    if(operation == Operation.Plus)
                    {
                        vectorResult[j] += collectionsNumbers[i, j];
                    }
                    else if(operation == Operation.Minus)
                    {
                        vectorResult[j] -= collectionsNumbers[i, j];
                    }
                }
            }
            return vectorResult;
        }
        public string TranformVectorToString(int[] vector)
        {
            string res = "[";
            for (int i = 0; i < vector.Length; i++)
            {
                string jump = (i < vector.Length - 1) ? ", " : "";
                res += vector[i];
                res += jump;
            }
            res += "]";
            return res;
        }
    }
}
