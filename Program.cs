using System;

namespace HomeWork_1
{
    class Program
    {
        static void Main(string[] args)
        {
            EvenNumberInArray();
            NumberComparing();
            WordSorting();
            FindTheWordsAndLetters();
        }
        //**********************************************
        public static void EvenNumberInArray(){

            Console.WriteLine("Lütfen pozitif bir sayı giriniz: ");
            int n =Convert.ToInt32(Console.ReadLine());
            
                if(n<=0){
                     Console.WriteLine("Pozitif bir sayı girmediniz !!!");
                     Console.WriteLine("******************************");
                     return ;
                     }
            
            Console.WriteLine("{0} Adet sayı giriniz: ",n);
            int[] sayilar = new int[n];
            int kacCift=0;
            int[] ciftSayilar = new int[kacCift];
                for (int i = 0; i < n; i++)
                {
                     int girdi = Convert.ToInt32(Console.ReadLine());
                      sayilar[i]= girdi;
                     if (girdi%2==0)
                     {
                        Console.WriteLine("{0} sayısı çift sayıdır.",sayilar[i]);
                     }
                }
            
        }
        //**********************************************
        public static void NumberComparing(){

            Console.WriteLine("Eşit veya tam bölünen olup olmadığını kontrol etmek istediğiniz sayıyı (m) giriniz: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Giriş yapmak istediğiniz sayı adedini (n) giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            int[] sayilar = new int[n];
            
            for (int i = 0; i < n; i++)
            {
                int girdi = Convert.ToInt32(Console.ReadLine());
                if (girdi==m)
                {
                    Console.WriteLine("{0} sayısı girmiş olduğunuz m sayısına eşittir.",girdi);
                }else if (m%girdi==0)
                {
                    Console.WriteLine("{0} sayısı girmiş olduğunuz m sayısının tam bölenidir.",girdi);
                }
            }
        }
        //**********************************************
        public static void WordSorting(){

            Console.WriteLine("Girmek istediğiniz kelime adedini belirtin: ");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] kelimeler = new string[n];

            for (int i = 0; i < n; i++)
            {
                string kelime = Console.ReadLine();
                kelimeler[i]=kelime;
            }
            Array.Reverse(kelimeler);
            for (int i = 0; i < n; i++)
            {
               Console.WriteLine(kelimeler[i]); 
            }
            
        }
        //**********************************************

        public static void FindTheWordsAndLetters(){

            Console.WriteLine("Lütfen bir cümle yazınız: ");
            string cümle = Console.ReadLine();
            
            int harfSayisi=0;
            int kelimeSayisi=0;
           
           foreach (var item in cümle)
           {
               string[] dizi = cümle.Split(" ");
               string.Join("",dizi);
               kelimeSayisi=dizi.Length;
           }
            foreach (var harf in cümle)
            {
                harfSayisi++;
            }
            Console.WriteLine("Cümledeki harf sayısı : {0}",(harfSayisi-(kelimeSayisi-1)));
            Console.WriteLine("Cümledeki kelime sayısı : {0}",kelimeSayisi);
            

        }
      


    }
}
