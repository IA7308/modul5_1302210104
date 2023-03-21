using System.Runtime.CompilerServices;

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
    }
}