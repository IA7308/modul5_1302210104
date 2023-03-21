public class Penjumlahan
{
    public static T JumlahTigaAngka<T> (T t, T a, T b)
    {
        dynamic input1 = t;
        dynamic input2 = a;
        dynamic input3 = b; 
        
        return input1 + input2 + input3;   
    }

    public static void Main(string[] args)
    {
        Penjumlahan Tambah = new Penjumlahan();
        Console.WriteLine(Penjumlahan.JumlahTigaAngka(13, 02, 21));
    }
}