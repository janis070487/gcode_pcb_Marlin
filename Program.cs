using System;

namespace Gcode
{
    class Program
    {
        static void Main(string[] args)
        {
          

            string path = "test_gcode";

            File file = new File();
            file.add(Start.start());
            file.add(Move.UpZ());
            file.save(path);
        }
    }
}
