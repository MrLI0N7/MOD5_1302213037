// See https://aka.ms/new-console-template for more information

public class Penjumlahan<T>
{
    public void JumlahTigAngka(T var1, T var2, T var3){

        int sum = (dynamic)var1 + var2 + var3;
        Console.WriteLine(sum);
    }


} 

public class Program
{
    public static void Main(string[] args)
    {
        Penjumlahan<int> angka = new Penjumlahan<int>();

        int input1 = 13 ;
        int input2 = 22 ;
        int input3 = 37;
        
        angka.JumlahTigAngka(input1, input2, input3);
        

    }
}