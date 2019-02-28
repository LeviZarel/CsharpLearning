using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    class VectorCollections
    {
        private string[,] array;
        private const char filter = ',';
        private string defaultValue = "0";
        private int rowLength;
        private int colLength;
        public VectorCollections(string[] args)
        {
            rowLength = args.Length;
            colLength = MaxColLength(args);
            array = new string[rowLength, colLength];
            for (int i = 0; i < rowLength; i++)
            {
                string[] words = args[i].Split(filter);
                for (int j = 0; j < colLength; j++)
                {
                    if (j < words.Length)
                    {
                        array[i, j] = (words[j]=="")? defaultValue: words[j];
                    }
                    else
                        array[i, j] = defaultValue;
                }
            }
        }
        public int MaxColLength(string[] args)
        {
            int maxLength = 0;
            foreach (var word in args)
            {
                int currentLength = word.Split(filter).Length;
                if (currentLength > maxLength)
                    maxLength = currentLength;
            }
            return maxLength;
        }
        public override string ToString()
        {
            string res = "";
            for (int i = 0; i < rowLength; i++)
            {
                res += "[";
                for (int j = 0; j < colLength; j++)
                {
                    res += array[i, j];
                    res += (j < colLength - 1) ? ", " : "";
                }
                res += "]";
                res += (i < rowLength- 1) ? ", " : "";
        }
            return res;
        }

        public int[,] TransformNumber()
        {
            int[,] arrayResult = new int[rowLength, colLength];
            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    arrayResult[i, j] = parseStringToInt(array[i, j]);
                }
            }
            return arrayResult;
        }
        private int parseStringToInt(string str)
        {
            int res = 0;
            try
            {
                res = System.Convert.ToInt32(str);
            }
            catch (FormatException)
            {
                // the FormatException is thrown when the string text does 
                // not represent a valid integer.
            }
            catch (OverflowException)
            {
                // the OverflowException is thrown when the string is a valid integer, 
                // but is too large for a 32 bit integer.  Use Convert.ToInt64 in
                // this case.
            }
            return res;
        }
    }
}
