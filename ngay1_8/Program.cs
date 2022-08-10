using System;

namespace ngay1_8
{
    class Program
    {
        static void Main(string[] args)
        {/*
          * nhap xuat co ban
          * 
            Console.WriteLine("hello");
            Console.Write("ten cua ban la: ");
            Console.WriteLine("xin chao: " + Console.ReadLine());
            Console.Write("ngay sinh cua ban la: ");
            Console.WriteLine(" ngay sinh: " + Console.ReadLine());
            Console.Write("noi o cua ban la: ");
            Console.WriteLine("ban dang o: " + Console.ReadLine());
            Console.ReadKey();

            */



            /*  //bien va kieu du lieu

              byte BienByte = 20;
              short BienShort = 32;
              int BienInt = 322;
              long BienLong = 300;
              long? f=null; //ko the gan null cho cac kieu long, int , byte..
              BienInt = BienByte;
              Console.WriteLine("BienInt= " + BienInt);

              float BienFloat = 20.876F;
              double BienDouble = 29.09;

              char BienChar = 't';
              string BienString = "xin chao cac ban";

              Console.ReadLine();

              */


            /*
             * toan tu 
            int i = 5, j = 5;

            i += j;//i=i+j
            j = i++;
            Console.WriteLine(i);
            Console.WriteLine(j);

            int t, h, u;
            t = h = u = 20;
            Console.WriteLine("h={0}, t={1}, u ={2}", t,h,u);

            u += h = t = 30;
            Console.WriteLine("h={0}, t={1}, u ={2}", t, h, u);

            string strSN;
            int SN;
            string kq;

            Console.Write("nhap so can kiem tra: ");
            strSN = Console.ReadLine();
            SN = Int32.Parse(strSN);//ep kieu du lieu dang string sang dang int
            kq = (SN % 2 == 0) ? "so chan" : "so le";

            Console.WriteLine( "{0} la {1}", SN,kq);
            Console.ReadKey();
            */


            /*
            //doi do C sang do K va do F
            Console.Write("Nhap do C can chuyen doi: " );
            int Cel = Convert.ToInt32(Console.ReadLine());
            int K = Cel + 273;
            double F = Cel * 18 / 10 + 32;
            Console.WriteLine("do K tuong ung la: "+ K);
            Console.WriteLine("do F tuong ung la: "+F);
            Console.ReadLine();
            */


            /*  if.....else
             *  
            Console.Write("nhap nam sinh: ");
            int namSinh = Convert.ToInt32(Console.ReadLine());
            int now = 2022;
            int tuoi = now - namSinh;
            Console.WriteLine("ban nam nay "+tuoi+" tuoi!!");

            if (tuoi < 16)
            {
                Console.WriteLine("Ban dang " + tuoi + " tuoi,  chi thieu nien thoi");

            }
            else if (tuoi < 18)
            {
                Console.WriteLine("Ban dang " + tuoi + " tuoi, vi thanh nien thoi nhe");
            }
            else {
                Console.WriteLine("Ban dang " + tuoi + " tuoi, truong thanh roi");
            }
            Console.ReadLine();
            */



            /*switch....case
             string can = "", chi = "";

             Console.Write("Nhap nam can xem: ");
             int Nam = Convert.ToInt32(Console.ReadLine());
             //tim can:
             switch (Nam % 10)
             {
                 case 0:
                     can = "Canh";
                     break;
                 case 1:
                     can = "Tan";
                     break;
                 case 2:
                     can = "Nham";
                     break;
                 case 3:
                     can = "Quy";
                     break;
                 case 4:
                     can = "Giap";
                     break;
                 case 5:
                     can = "At";
                     break;
                 case 6:
                     can = "Binh";
                     break;
                 case 7:
                     can = "Dinh";
                     break;
                 case 8:
                     can = "Mau";
                     break;
                 case 9:
                     can = "Ky";
                     break;
             }
             //tim chi
             switch (Nam % 12)
             {
                 case 0:
                     chi = "Than";
                     break;
                 case 1:
                     chi = "Dau";
                     break;
                 case 2:
                     chi = "Tuat";
                     break;
                 case 3:
                     chi = "Hoi";
                     break;
                 case 4:
                     chi = "Ti";
                     break;
                 case 5:
                     chi = "Suu";
                     break;
                 case 6:
                     chi = "Dan";
                     break;
                 case 7:
                     chi = "Mao";
                     break;
                 case 8:
                     chi = "Thin";
                     break;
                 case 9:
                     chi = "Ti";
                     break;
                 case 10:
                     chi = "Ngo";
                     break;
                 case 11:
                     chi = "Mui";
                     break;

             }
             Console.WriteLine("Nam {0} co nam am lich la: {1} {2}", Nam, can, chi);
             Console.ReadLine();

             */

            //tinh lich can chi su dung mang 1 chieu

            //int Year;
            //Console.Write("nhap nam ban muon xem: ");
            //Year = Int32.Parse(Console.ReadLine());

            //string[] Can = {"canh","tan","nham","quy","giap","at","binh","dinh","mau","ky" };
            //string[] Chi = { "than","dau","tuat","hoi","ti","suu","dan","mao","thin","ti"};

            //Console.WriteLine("Nam {0} co nam am lich la: {1} {2}", Year, Can[Year % 10], Chi[Year % 12]);
            //Console.ReadLine();



        }
    }
}
