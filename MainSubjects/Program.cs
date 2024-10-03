using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region YazdırmaKomutları
            //Console.Write("Merhaba Dünya!");
            //Console.WriteLine("Selam");


            //Console.WriteLine("****** Yemek Kategorileri********");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");

            #endregion


            #region Değişkenler


            //String
            //Değişken_türü değiken_adı;

            //string name;
            //name = "Hasan";
            //Console.WriteLine(name);

            //string customerName;
            //string customerSurame;
            //string customerPhone;
            //string customerEmail,district,city;

            //customerName = "Hasan";
            //customerSurame = "ERGUNT";
            //customerPhone = "+90551 111 1111";
            //customerEmail = "hasanerguntt@gmail.com";
            //district = "Çivril";
            //city = "Denizli";




            //Console.WriteLine("*****Rezervasyon Kartı *****");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------------");
            //Console.WriteLine("Müşteri" + customerName + " " + customerSurame);
            //Console.WriteLine("İletişim" +customerPhone);
            //Console.WriteLine("" + customerEmail);
            //Console.WriteLine("Müşteri" + customerName + " " + customerSurame);
            //Console.WriteLine("Adres: "+district+"/"+city);
            //Console.WriteLine("------------------------------------------");



            //customerName = "Ayşegül";
            //customerSurame = "Kaya";
            //customerPhone = "+90400 300 80 70 ";
            //customerEmail = "test@gmail.com";
            //district = "Sapanca";
            //city = "Sakarya";

            //Console.WriteLine("*****Rezervasyon Kartı *****");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------------");
            //Console.WriteLine("Müşteri" + customerName + " " + customerSurame);
            //Console.WriteLine("İletişim" + customerPhone);
            //Console.WriteLine("" + customerEmail);
            //Console.WriteLine("Müşteri" + customerName + " " + customerSurame);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("------------------------------------------");
            #endregion


            #region Int değişkenler
            //int
            //int number=24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("****Restoran Menü Fiyatı ");
            Console.WriteLine("-----Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("-----Pizza: " + pizzaPrice + " TL");
            Console.WriteLine("-----Kola: " + cokePrice + " TL");
            Console.WriteLine("-----Limonata: " + lemonadePrice + " TL");
            Console.WriteLine("-----Kızartma: " + friesPrice + " TL");
            Console.WriteLine("-----Kola: " + cokePrice + " TL");
            Console.WriteLine("");
            Console.WriteLine("**** Restoran Menü Fiyatı ****");

            Console.WriteLine();

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;



            Console.WriteLine("------------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + "TL");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + "TL");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + "TL");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + "TL");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + "TL");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + "TL");

            int totalPrice = totalHamburgerPrice + totalPizzaPrice + totalFriesPrice + totalCokePrice + totalLemonadePrice + totalWaterPrice;
            Console.WriteLine();
            Console.WriteLine("Toplam Ödenecek Tutar= " + totalPrice);

            #endregion


            Console.Read();






        }
    }
}