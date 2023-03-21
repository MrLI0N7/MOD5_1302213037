// See https://aka.ms/new-console-template for more information

public class Penjumlahan<T>
{
    public void JumlahTigAngka(T var1, T var2, T var3){

        int sum = (dynamic)var1 + var2 + var3;
        Console.WriteLine("Jumlah =" + sum);
    }


} 

public class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }
    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }
    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine("Data" + (i + 1) + " berisi: " + storedData[i] + " yang disimpan pada waktu " + inputDates[i]);
        }


    }
}

public class Program
    {
   public static void Main(string[] args)
   {
        Penjumlahan<int> angka = new Penjumlahan<int>();

        int input1 = 13;
        int input2 = 22;
        int input3 = 37;

        angka.JumlahTigAngka(input1, input2, input3);

        Console.WriteLine();

        SimpleDataBase<int> database = new SimpleDataBase<int>();
        database.AddNewData(13);
        database.AddNewData(22);
        database.AddNewData(37);
        database.PrintAllData();
   }
}

