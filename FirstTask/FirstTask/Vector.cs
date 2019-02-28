using System;

namespace FirstTask
{
    class Vector
    {
        private string[,] array;
        private const char filter = ',';
        private string defaultValue = "0";
        private int rowLength;
        private int colLength;

        public Vector(string[] args)
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
                        array[i, j] = words[j];
                    else
                        array[i, j] = defaultValue;
                }
            }
        }

        public override string ToString()
        {
            string res = "";
            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    res += array[i, j];
                    res += (j < colLength - 1) ? "," : "";
                }
                res += "\n";
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

        public int parseStringToInt(string str)
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

        public int[] Sum()
        {
            int [,] arrayOfNumbers = TransformNumber();
            int[] res = new int[colLength];
            for (int i = 0; i < colLength; i++)
            {
                res[i] = 0;
            }
            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    res[j] += arrayOfNumbers[i, j];
                }
            }
            
            return res;
        }

        public string ToString(int[] vect)
        {
            string res = "[";
            for (int i = 0; i < vect.Length; i++)
            {
                string jump = (i < vect.Length - 1) ? ", " : "";
                res += vect[i];
                res += jump;
            }
            res += "]";
            return res;
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

    }
}
