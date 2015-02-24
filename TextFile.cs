using System;
using System.IO;

class TextFile
{
    String path;
    String text;

    public static void Main(String[] args)
    {
        TextFile file = new TextFile();
        file.load(args[0]).print();
    }

    public TextFile() {}

    public TextFile load(String path)
    {
        this.path = path;
        //StreamReader file = new StreamReader(path);
        StreamReader file = new StreamReader(path, System.Text.Encoding.GetEncoding("Big5"));
        text = file.ReadToEnd();
        file.Close();
        return this;
    }

    public TextFile save()
    {
        StreamWriter file = new StreamWriter(path);
        //StreamWriter file = new StreamWriter(path, System.Text.Encoding.GetEncoding("Big5"));
        file.Write(text);
        file.Close();
        return this;
    }

    public TextFile print()
    {
        Console.WriteLine("file: path="+path);
        Console.WriteLine(text);
        return this;
    }
}
