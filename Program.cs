using System;
using System.IO;
namespace Gcode
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] data = null;
            string path = "test_gcode.txt";
           FileLoad f = new FileLoad(path);
            f.Load(ref data);
            for(int i = 0; i < data.Length; i++)
            {
                Console.WriteLine(data[i]);
            }
        }
    }
}
