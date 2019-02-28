using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    public class VectorCollections
    {
        private const char Filter = ',';
        private const int MaxArguments = 50;
        private const string MaxArgumentsMessage = "Numbers of Arguments is Exceded";
        private const string InvalidNumberMessage = "Vector Arguments must supply valid numbers.";
        private List<Vector2D> Vectors = new List<Vector2D>();

        public VectorCollections(string[] args)
        {
            if(args.Length <= MaxArguments)
            {
                for (int i = 0; i < args.Length; i++)
                {
                    string[] filtrate = args[i].Split(Filter);
                    string[] argComplete = new string[2];
                    argComplete[0] = filtrate[0];
                    argComplete[1] = (filtrate.Length == 1) ? "0": filtrate[1];
                    var vector = new Vector2D(ParseToInt(argComplete[0]), ParseToInt(argComplete[1]));
                    Vectors.Add(vector);
                }
            }
            else
            {
                throw new ArgumentException(MaxArgumentsMessage);
            }
        }

        public Vector2D getVectorByIndex(int index)
        {
            return Vectors[index];
        }

        private int ParseToInt(string value)
        {
            if (!int.TryParse(value, out var parsedValue))
            {
                throw new ArgumentException(InvalidNumberMessage);
            }
            return parsedValue;
        }
    }
}
