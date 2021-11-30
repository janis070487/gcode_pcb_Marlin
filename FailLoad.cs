using System;
using System.IO;
public class FileLoad
{
	private string path;
	string[] data;
	public FileLoad(string path)
	{
		this.path = path;
	}
	public void Load(ref string[] data)
    {
        if (File.Exists(path))
        {
			data = File.ReadAllLines(path);
        }
        else
        {
			Console.WriteLine("Fails neeksistē");
        }
		string[] result = new string[0];
		
    }
}
