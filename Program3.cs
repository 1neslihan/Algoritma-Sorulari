using System;
namespace alistirma
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Kullanıcıdan alınan bir cümledek, kelime ve harf sayısını ekrana yazdırma*/

           string str;

           Console.Write("Bir cumle giriniz: ");
           str=Console.ReadLine();

           string[] sdizi =str.Split(' ');

           int counter=0;

           foreach(var items in sdizi){
            counter++;
           }

           Console.WriteLine();
           Console.Write("Cumledeki kelime sayisi: "+ counter);
           Console.WriteLine();
           str=str.Replace(" ","");
           Console.Write("Cumledeki harf sayisi: "+ str.Length);




           
           


        }
    }

}