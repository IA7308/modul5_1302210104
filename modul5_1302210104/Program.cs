public class Penjumlahan
{
    public static T JumlahTigaAngka<T>(T t, T a, T b)
    {
        dynamic input1 = t;
        dynamic input2 = a;
        dynamic input3 = b;

        return input1 + input2 + input3;
    }

}

public class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase() { 
        this.storedData = new List<T>();
        this.inputDates = new List<DateTime>();
    }
  
    public void AddNewData(T data)
    {
        this.storedData.Add(data);
        this.inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        for(int i = 0; i<storedData.Count(); i++) 
        {
            Console.WriteLine("Data " + i + " berisi: " + storedData[i] +", yang disimpan pada waktu UTC: " + inputDates[i]);
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        SimpleDataBase<float> DataBase = new SimpleDataBase<float>();
        DataBase.AddNewData(13);
        DataBase.AddNewData(02);
        DataBase.AddNewData(21);
        DataBase.PrintAllData();

        Penjumlahan Tambah = new Penjumlahan();
        Console.WriteLine(Penjumlahan.JumlahTigaAngka(13, 02, 21));
    }
}