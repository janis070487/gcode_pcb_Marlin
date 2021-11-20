using System;
using System.IO;
public class File
{
	private char[] data;
    public File()
    {
        data = new char[0];
    }
	public void add( char[] obj)
    {
        
        char[] _data = new char[obj.Length + data.Length];
        int karta = 0;
        karta = data.Length;
        for(int i = 0; i < data.Length; i++)
        {
            _data[i] = data[i];
           // karta++;
        }
        for(int a = karta; a < _data.Length; a++)
        {
            _data[a] = obj[a - karta];
        }
        data = _data;
    }
    public void save(string path, string seting = "txt")
    {
        string pathTXT = path + ".txt";
        string pathGCODE = path + ".gcode";
        byte[] array = System.Text.Encoding.Default.GetBytes(data);
        if (seting == "txt")
        {
            using (FileStream fs = new FileStream(pathTXT, FileMode.OpenOrCreate))
            {
                try
                {
                    fs.Write(array, 0, data.Length);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Kluda atvert vai nolasit failu");
                }
            }
        }
        //--------------------------------------------------------------
        if (seting == "gcode")
        {
            using (FileStream fs = new FileStream(pathGCODE, FileMode.OpenOrCreate))
            {
                try
                {
                    fs.Write(array, 0, data.Length);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Kluda atvert vai nolasit failu");
                }
            }
        }
        //--------------------------------------------------------------
        if (seting == "txt gcode" || seting == "gcode txt")
        {
            using (FileStream fs = new FileStream(pathTXT, FileMode.OpenOrCreate))
            {
                try
                {
                    fs.Write(array, 0, data.Length);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Kluda atvert vai nolasit failu");
                }
            }

            using (FileStream fs = new FileStream(pathGCODE, FileMode.OpenOrCreate))
            {
                try
                {
                    fs.Write(array, 0, data.Length);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Kluda atvert vai nolasit failu");
                }
            }
        }
        //--------------------------------------------------------------

    }
}
