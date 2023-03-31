using System;
using System.IO;
using System.Text;


namespace LowerUnion
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Array.Sort(args);

            StringWriter output = new StringWriter();

            if (args.Length == 0)
            {
                output.Write("sem qualquer tipo de argumento!");
            }

            else
            {
                for (int i = 0; i < args.Length; i++)
                {
                    output.Write(args[i].ToLower());
                    
                    if (i != args.Length - 1)
                    {
                        output.Write("_");
                    }
                }
            }
            Console.WriteLine(output.ToString());
        }
    }
}
