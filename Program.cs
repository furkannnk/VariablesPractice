using System;

namespace VariablesPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 5;     //1 byte
            sbyte c = 5;    //1 byte

            short s = 5;   //2 byte
            ushort us = 5;  //2 byte

            Int16 i16 = 2;   //2byte
            int i = 2;       //4 byte
            Int32 i32 = 2;   //4 byte
            Int64 i64 = 2;   //8 byte

            uint ui = 2;     //4 byte
            long l = 4;      //8 byte
            ulong ul = 4;    //8 byte
            
            //Reel sayılar
            float f = 5;     //4 byte
            double d = 5;    //8 byte
            decimal de = 5;  //16 byte

            char ch = '2';   //2 byte
            string str = "Selam";  //Sınırsız

            bool b1 = true; 
            bool b2 = false;

            DateTime dt = DateTime.Now;

            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 5.3;

            //string
            string str1 = string.Empty;
            str1 = "Pablo Picasso";
            string ad = "Pablo";
            string soyad = "Picasso";
            string tamisim = ad + " " + soyad;

            //int
            int i1 = 5;
            int i2 = 3;
            int i3 = i1*i2;

            //bool
            bool bool3 = 2<10;

            //Dönüşümler
            string str20 = "20";
            int int20 = 20;
            
            string deger = str20 + int20.ToString(); //2020
            Console.WriteLine(deger);

            int yeniDeger = int20 + Convert.ToInt32(str20);  //40
            Console.WriteLine(yeniDeger); 

            //Date time
            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);

        }
    }
}
