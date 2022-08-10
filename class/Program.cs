using System;


//public class Animal
//{
//    public double Weight;
//    public double Height;


//    public void Info()
//    {
//        Console.WriteLine("Height: " + Height + "cm,    " + "Weight: " + Weight + "kg.");

//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        Animal Dog = new Animal();
//        Dog.Weight = 3;
//        Dog.Height = 20;

//        Animal Cat = new Animal();
//        Cat.Weight = 5;
//        Cat.Height = 40;

//        Dog.Info();
//        Cat.Info();
//    }
//}

//PHUONG THUC KHOI TAO CONSTRUCTOR



//    //tinh the tich hinh hop
//    public class Box {
//        private double chieuDai;
//        private double chieuRong;
//        private double chieuCao;

//        public void setChieuDai(double cd)
//        {
//            chieuDai = cd;
//        }
//        public void setChieuRong(double cr)
//        {
//            chieuRong = cr;
//        }
//        public void setChieuCao(double cc)
//        {
//            chieuCao = cc;

//        }
//        public double TheTich() {
//            return chieuCao * chieuDai * chieuRong;
//        }
//    }
//    public class program
//    {
//        public static void Main(string[] args)
//        {
//            Box box1 = new Box();
//            Box box2 = new Box();
//            double theTich;

//            //nhap thong tin box 1
//            box1.setChieuDai(3);
//            box1.setChieuRong(2);
//            box1.setChieuCao(5);

//            //nhap thong tin box 2
//            box2.setChieuDai(6);
//            box2.setChieuRong(5);
//            box2.setChieuCao(7);

//            //tinh the tich box 1:
//            theTich = box1.TheTich();
//            Console.WriteLine("the tich box 1 la: " + theTich);

//            //tinh the tich box2
//            theTich = box2.TheTich();
//            Console.WriteLine("The tich box 2 la: " + theTich);

//            Console.ReadLine();
//        }

//    }

//ham tinh static method
//class LuyThua
//{
//    public static long luyThua(int coSo, int soMu)
//    {
//        long ketQua = 1;

//        for(int i=0;i<soMu;i++)
//        {
//            ketQua *= coSo;
//        }
//        return ketQua;
//     }
//}
//class program
//{
//    public static void Main(string[] args)
//    {
//        Console.WriteLine("ket qua la: "+ LuyThua.luyThua(5, 7));
//        Console.ReadKey();
//    }
//}



//static class
//class Color
//{
//    public static string MainColor;
//    static Color()
//    {
//        DateTime now = DateTime.Now;

//        switch(now.DayOfWeek)
//        {
//            case DayOfWeek.Monday:
//                MainColor = "Green";
//                break;
//            case DayOfWeek.Tuesday:
//                MainColor = "Red";
//                break;
//            case DayOfWeek.Wednesday:
//                MainColor = "Purple";
//                break;
//            case DayOfWeek.Thursday:
//                MainColor = "Yellow";
//                break;
//            case DayOfWeek.Friday:
//                MainColor = "Blue";
//                break;
//            case DayOfWeek.Saturday:
//                MainColor = "Orange";
//                break;
//            case DayOfWeek.Sunday:
//                MainColor = "Pink";
//                break;
//        }
//    }
//}
//class Program
//{
//    public static void Main(string[] args)
//    {
//        Console.WriteLine("Mau chu dao hom nay la: " + Color.MainColor);
//    }
//}



// viet ctr khai bao 2 mang a va b, mang c la tong 2 mang a+b
//class ArrId
//{
//    public void Input(int[]a, int n)
//    {
//        for(int i=0; i<n;i++)
//        {
//            a[i] = int.Parse(Console.ReadLine());
//        }
//        //----------------------------------------
//    }
//    public void Sum(int[]a, int[]b,int[]c,int n)
//    {
//        for(int i=0;i<n;i++)
//        {
//            c[i] = a[i] + b[i];
//        }
//    }
//    //-------------------------------------
//    public void Show(int[]a, int n)
//    {
//        for(int i=0;i<n;i++)
//        {
//            Console.Write("  " + a[i]);
//        }
//    }
//}
//class Program
//{
//    public static void Main(string[] args)
//    {
//        ArrId ob = new ArrId();
//        int n;
//        Console.Write("nhap n: ");
//        n = int.Parse(Console.ReadLine());

//        int[] a = new int[n];
//        int[] b = new int[n];
//        int[] c = new int[n];

//        Console.WriteLine("nhap cac phan tu mang a: ");
//        ob.Input(a,n);
//        Console.WriteLine("nhap cac phan tu mang b: ");
//        ob.Input(b, n);
//        ob.Sum(a, b, c, n);

//        Console.WriteLine("Hien thi cac mang a,b,c:");

//        Console.WriteLine("\nmang a: ");
//        ob.Show(a, n);
//        Console.WriteLine("\nmang b: ");
//        ob.Show(b, n);
//        Console.WriteLine("\nmang c=a+b ");
//        ob.Show(c, n);


//        Console.ReadLine();

//    }
//}



class person
{
    private string name;
    private int age;
    private double salary;

    public person()
    {
        name = "";
        age = 0;
        salary = 0;
    }
    public void Input()
    {
        Console.WriteLine();

        Console.Write("nhap ten: ");
        name = Console.ReadLine();

        Console.Write("nhap tuoi: ");
        age = int.Parse(Console.ReadLine());

        Console.Write("Nhap luong: ");
        salary = double.Parse(Console.ReadLine());
        Console.WriteLine();
    }
    public void show()
    {
        Console.WriteLine("Ten: " + name + ", Tuoi: " + age + ", Luong: " + salary);
    }
}

class Program
{
    public static void Main(string[] args)
    {
        int n;
        Console.Write("nhap so nhan vien: ");
        n = int.Parse(Console.ReadLine());
        person[] p = new person[n];
        {
            for(int i=0; i<n;i++)
            {
                p[i] = new person();//khoi tao doi tuong
                p[i].Input();//mang doi tuong
            }
            for(int i=0; i<n;i++)
            {
                p[i].show();
                Console.ReadLine();
            }
        }

    }
}
