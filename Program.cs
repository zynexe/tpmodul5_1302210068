using System;

public class HaloGeneric
{
    public void SapaUser<T>(T user)
    {
        Console.WriteLine("Halo user " + user);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();
        string namaPanggilan = "John"; // Isi nilai nama panggilan praktikan
        halo.SapaUser(namaPanggilan); // Panggil method SapaUser dengan input nama panggilan praktikan
    }
}
