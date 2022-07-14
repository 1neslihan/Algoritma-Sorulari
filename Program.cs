using System;
namespace alistirma
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            Kullanicidan iki adet sayi alinir n sayisi ve m sayisi
            daha sonra n sayisi kadar sayi girmesi istenir ve m sayisiyla eşit olanları 
            veya m'e tam bölünenleri ekrana yazdırır.
            */
           Console.WriteLine("iki pozitif tam sayi giriniz: ");
           int n;
           int m;
           

           Console.Write("1. sayi n(sayisi): ");
           n=Convert.ToInt32(Console.ReadLine());

           int[] ndizi=new int[n];
           Console.WriteLine();
           Console.Write("2. sayi m(sayisi): ");
           m=Convert.ToInt32(Console.ReadLine());

           Console.WriteLine();
           Console.WriteLine(n +" adet sayi giriniz.");
           Console.WriteLine();

           for(int i=0;i<n;i++){

            Console.Write((i+1) +". sayi: ");
            ndizi[i]=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

           }
           Console.WriteLine();
           Console.WriteLine("girilen sayilardan m'e eşit olan veya tam bölünenler");


           for(int i=0; i<n;i++){
            if(ndizi[i]== m || ndizi[i]%m==0){
                Console.WriteLine(ndizi[i]);
            }
           }

           
           
           


        }
    }
}
