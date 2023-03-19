using System;

public class DataGeneric<T>
{
    private T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + data);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        DataGeneric<string> data = new DataGeneric<string>("101011101000101"); // Isi dengan NIM
        data.PrintData(); // Panggil method PrintData()
    }
}
