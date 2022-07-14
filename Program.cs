using System;
namespace cs_calisma
{
    class Program
    {
        static void Main(string[] args)
        {
           int sayiAdet;
           
           Console.Write("Kac adet sayi girmek istiyorsunuz?: ");

           sayiAdet=Convert.ToInt32(Console.ReadLine());

           int[] dizi=new int[sayiAdet];

           for(int i=0;i<sayiAdet;i++){

            Console.Write( (i+1) +". sayiyi giriniz: ");
            dizi[i]=Convert.ToInt32(Console.ReadLine());

           }

          Console.WriteLine("Çift elemanlar: ");
          
           for(int i=0; i<dizi.Length;i++){
            if(dizi[i]%2==0){
                Console.WriteLine(dizi[i]);
            }

           }
        
           
           


        }
    }
}
