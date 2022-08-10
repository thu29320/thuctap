using System;

namespace KeThua
{
    //class HinhHoc
    //{
    //    protected float chieuRong;
    //    protected float chieuDai;

    //    public void setChieuDai(float cd)
    //    {
    //        chieuDai = cd;
    //    }
    //    public void setChieuRong(float cr)
    //    {
    //        chieuRong = cr;
    //    }
    //}
    ////lop HinhChuNat la ke thua lop HinhHoc
    //class HinhChuNhat:HinhHoc
    //{
    //    public float tinhDienTich()
    //    {
    //        return (chieuRong * chieuDai);
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //tao doi tuong hcn:
    //        HinhChuNhat hcn = new HinhChuNhat();

    //        hcn.setChieuDai(7);
    //        hcn.setChieuRong(4);
    //        Console.WriteLine("Dien tich hcn can tinh la: "+hcn.tinhDienTich());
    //    }
    //}


    //class HinhChuNhat
    //{
    //    protected float chieuDai;
    //    protected float chieuRong;
    //    //constructor:
        
    //    public HinhChuNhat(float cd, float cr)
    //    {
    //        chieuDai = cd;
    //        chieuRong = cr;
    //    }
    //    //ham tinh dien tich
    //    public float TinhDienTich()
    //    {
    //        return chieuRong * chieuDai;
    //    }
    //    public void Display()
    //    {
    //        Console.WriteLine("chieu dai la: " + chieuDai);
    //        Console.WriteLine("Chieu rong la: " + chieuRong);
    //        Console.WriteLine("dien tich hcn la: " + TinhDienTich());
    //    }
    //}
    //class PhiXayDung:HinhChuNhat
    //{
    //    private float chiPhi;
    //    public PhiXayDung(float cd, float cr) : base(cd, cr) 
    //    { 
        
    //    }
    //    public float tinhChiPhi()
    //    {
    //        float chi_phi;
    //        chi_phi = TinhDienTich() * 90;
    //        return chi_phi;
    //    }

    //    public void hienThiThongTin()
    //    {
    //        base.Display();
    //        Console.WriteLine("chi phi: " + tinhChiPhi() +" $");
    //    }
    //}

    //class Program
    //{
    //    public static void Main()
    //    {
    //        //tao doi tuong phi xay dung

    //        PhiXayDung t = new PhiXayDung(6, 9);
    //        t.hienThiThongTin();
    //        Console.ReadLine();

    //    }
    //}





    //ke thua+da hinh
    //class DongVat //base class
    //{
    //    // Phương thức đa hình phải được ghi đè(override) ở các lớp con

    //    //Virtual là từ khoá dùng để khai báo 1 phương thức ảo
    //    //(phương thức ảo là phương thức có thể ghi đè(override) được).
    //    public virtual void TiengKeu()
    //    {
    //        Console.WriteLine(" cac con vat keu nhu the nao?");

    //    }
    //}
    //class Lon:DongVat //lop con
    //{
    //    public override void TiengKeu()
    //    {
    //        Console.WriteLine("con lon keu: ut it");
    //    }
       
    //}
    //class Cho: DongVat
    //{
    //    public override void TiengKeu()
    //    {
    //        Console.WriteLine("Con cho keu: Gau gau");

    //    }
    //}
    //class Meo: DongVat
    //{
    //    public override void TiengKeu()
    //    {
    //        Console.WriteLine("Con meo keu: meo meo");
    //    }
    //}

    //class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        DongVat DV = new DongVat(); //tao mot doi tuong dong vat
    //        DongVat lon = new Lon();
    //        DongVat cho = new Cho();
    //        DongVat meo = new Meo();

    //        DV.TiengKeu();
    //        cho.TiengKeu();
    //        meo.TiengKeu();
    //        lon.TiengKeu();
    //    }
    //}




    //internal class Bird
    //{
    //    private int _weight;
    //    public int Weight
    //    {
    //        get => _weight;
    //        set
    //        {
    //            if(value>0)
    //            {
    //                _weight = value;
    //            }
    //        }
    //    }
    //    public void Feed() => _weight += 10;
    //    public Bird() => Console.WriteLine("Bird created");
    //    public Bird(int weight)
    //    {
    //        _weight = weight;
    //        Console.WriteLine($"Bird created. {weight} gram.");
    //    }
    //    public void Fly() => Console.WriteLine("Bird is flying");
    //}
    //internal class Parrot: Bird
    //{
    //    public Parrot() => Console.WriteLine("Parrot created.");
    //    public Parrot(int weight) : base(weight) { }
    //    public void Speak() => Console.WriteLine("Parrot is speaking");

    //}
    //internal class Cockatoo: Parrot
    //{
    //    public Cockatoo() => Console.WriteLine("Cockatoo created");
    //    public void Dance() => Console.WriteLine("Cockatoo is dancing");
    //}
    //internal class MainClass
    //{
    //    private static void Main(string[] args)
    //    {
    //        Console.WriteLine("Bird: ");
    //        Bird bird = new Bird(50) { Weight = 100 };
    //        bird.Feed();
    //        Console.WriteLine($"Weight:  { bird.Weight}");
    //        bird.Fly();

    //        Console.WriteLine("\nParrot: ");
    //        Parrot parrot = new Parrot(200);
    //        parrot.Feed();
    //        Console.WriteLine($"Weight: {parrot.Weight}");
    //        parrot.Fly();
    //        parrot.Speak();

    //        Console.WriteLine("\nCockatoo: ");
    //        Cockatoo cockatoo = new Cockatoo() { Weight = 300 };
    //        cockatoo.Feed();
    //        Console.WriteLine($"Weight:  {cockatoo.Weight} ");
    //        cockatoo.Fly();
    //        cockatoo.Speak();
    //        cockatoo.Dance();
    //        Console.ReadLine();
    //    }
    //}
    abstract class Animal//lop truu tuong
    {
        public abstract void Eat();//phuong thuc truu tuong Eat ko co than
        public abstract void Move();
    }

    //Một class kế thừa từ lớp trừu tượng này bắt buộc
    //phải ghi đè tất cả phương thức trừu tượng của class mà nó thừa kế.
    class Dog :Animal
    {
        public override void Eat() => Console.WriteLine("I love Bone.");
        public override void Move() => Console.WriteLine("move by 4 feet.");
        
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Eat();
            dog.Move();

            Console.WriteLine();
        }
    }
}
