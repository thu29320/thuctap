using System;

namespace BaiTapThayTho
{
     class NhanVien
    {
        
        private string hoTen;
        private int namSinh;
        private string bangCap;
        private string congViec;
        public NhanVien()
        {
            hoTen = "";
            namSinh = 0;
            bangCap = "";
            congViec = "";
        }
        public virtual void CongViec()
        {

        }
        public virtual void Input()
        {
            Console.Write("nhap ho ten nhan vien: ");
            hoTen = Console.ReadLine();
            Console.Write("nhap nam sinh nhan vien: ");
            namSinh =int.Parse( Console.ReadLine());
            Console.Write("nhap bang cap nhan vien: ");
            bangCap = Console.ReadLine();
            Console.Write("nhap cong viec nhan vien: ");
            congViec = Console.ReadLine();
        }
        public virtual void Output()
        {
            Console.WriteLine("ho ten: "+hoTen);
            Console.WriteLine("nam sinh: "+namSinh);
            Console.WriteLine("bang cap: "+bangCap);
            Console.WriteLine("cong viec: "+congViec);
            //Console.Write("nhiem vu chinh:{0} ",CongViec());

        }
    }
    internal interface ILapTrinh
    {
        void PhanTichThietKe();
        void CaiDat();
        void KiemThu();

    }
     class LapTrinhVien: NhanVien, ILapTrinh
    {
        public LapTrinhVien() : base()
        { }
        public override void Input()
        {
            base.Input();
        }
        public override void Output()
        {
            base.Output();
        }
        public override void CongViec()=> Console.WriteLine("Coder: cong viec chinh la cai dat chuong trinh");
        public void PhanTichThietKe()=> Console.WriteLine("");
        public void CaiDat() => Console.WriteLine("");
        public void KiemThu() => Console.WriteLine();
    }
    class BA: NhanVien
    {
        public BA() : base()
        { }
        public override void Input()
        {
            base.Input();
        }
        public override void Output()
        {
            base.Output();
        }
        public override void CongViec()
        {
            Console.WriteLine("BA: Cong viec chinh la phan tich thiet ke");
        }
    }
    class Tester : NhanVien
    {
        public Tester() : base()
        { }
        public override void Input()
        {
            base.Input();
        }
        public override void Output()
        {
            base.Output();
        }
        public override void CongViec()
        {

            Console.WriteLine("Tester: cong viec chinh la Kiem thu");
        }
        
    }
    class ThongTinNhanVien
    {
        static void Main(string[] args)
        {
            string nm=""; int yy=0; string c="";
            int n;
            Console.Write("Nhap so nhan vien: ");
            n = int.Parse(Console.ReadLine());

            NhanVien[] NV = new NhanVien[n];

            for (int i = 0; i < n; i++)
            {
                LapTrinhVien lTV = new LapTrinhVien();
                lTV.CongViec();
                lTV.Input();
                lTV.Output();

                BA bA = new BA();
                bA.CongViec();
                bA.Input();
                bA.Output();

                Tester tester = new Tester();
                tester.CongViec();
                tester.Input();
                tester.Output();
                Console.ReadLine();
            }


            //LapTrinhVien lapTrinhVien = new LapTrinhVien();
            //    lapTrinhVien.CongViec();
            //    BA bA = new BA();
            //    bA.CongViec();
            //    Tester tester = new Tester();
            //    tester.CongViec();
            //     Console.ReadLine();
        }
    }
}
