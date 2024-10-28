using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü


            //Döngüler 1+2+3+4+5+6
            //3+3=6+4=10+5=15+6=21


            //For(x;y;z)
            //x:başlangıç
            //y:bitiş
            //z:artış-azalış

            //int i;
            //for (i=1; i <= 5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}



            //for (int i = 1;i<=20;i++) {
            //    Console.WriteLine(i);    
            //}

            //for (int i = 3; i <= 50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}





            //Console.Write("lütfen ekrana yazılmasını istediğiniz adedi giriniz: ");
            //int finishValue =int.Parse(Console.ReadLine());

            //for (int i = 1;i<=finishValue;i++) { 
            //Console.WriteLine("Yaşasın Cumhuriyet");
            //}

            #endregion


            #region For Döngüsü ile karar yapıları

            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}




            //int totalValue = 0;

            //for (int i = 1; i <= 10; i++) {
            // totalValue+=i;
            //}
            //Console.WriteLine(totalValue);



            //int totalValue = 0;

            //for (int i = 1; i < 20; i++) {
            //    if (i % 2 == 0) { 
            //    totalValue+=i;
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.WriteLine("------");
            //Console.WriteLine(totalValue);



            //int count = 0;
            //for (int i = 1; i <= 50; i++)
            //{

            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);




            //1-2-34-8-16-... her saat sonunda ikiye bölünerek çoğalıyor


            //int bacterium = 1;

            //for (int i = 1;i<=24;i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i+".Saat Sonunda : "+bacterium);
            //}



            #endregion

            #region While Döngüsü

            //While(Şart)

            //{
            //    işlemler
            //}



            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("Merhba Döngüler");

            //    i++;
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);

            //    }
            //    i++;
            //}



            //int i = 1;
            //int sum = 0;

            //while (i<=10)
            //{
            //    sum+=i;
            //    i++;
            //}
            //Console.WriteLine(sum);













            #endregion


            #region örnek sınav sorusu
            //klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız.
            int number;
            Console.Write("Lütfen 3 basamaklı bir sayı giriniz: ");
            number=int.Parse(Console.ReadLine());

            int ones, tens, hundreds;
            int sum;

            ones = number % 10;
            tens = (number % 100) / 10;
            hundreds = number / 100;


            Console.WriteLine(ones+"-"+tens+"-"+hundreds);

            sum=ones+tens+hundreds;
            Console.Write(sum);




            #endregion







            Console.Read();
        }
    }
}
