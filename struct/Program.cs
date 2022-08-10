using System;

//struct Book
//{
//    public string ten_sach;
//    public string tac_gia;
//    public string the_loai;
//    public int ma_sach;
//}

//    class program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Struct trong C#");
//        Console.WriteLine("----------------------------\n");

//        Book Book1;   /* khai bao Book1 thuoc kieu cau truc Book */
//        Book Book2;   /* khai bao Book2 thuoc kieu cau truc Book */

//        /* thong tin chi tiet ve Book1 */
//        Book1.ten_sach = "English Grammar in Use";
//        Book1.tac_gia = "Raymond Murphy";
//        Book1.the_loai = "Tieng Anh";
//        Book1.ma_sach = 6495407;

//        /* thong tin chi tiet ve Book2 */
//        Book2.ten_sach = "Toan hoc cao cap";
//        Book2.tac_gia = "Tran Van A";
//        Book2.the_loai = "Toan hoc";
//        Book2.ma_sach = 6495700;

//        /* in cac thong tin cua Book1*/
//        Console.WriteLine("In thong tin cua cuon sach 1:");
//        Console.WriteLine("Ten sach: {0}", Book1.ten_sach);
//        Console.WriteLine("Tac gia: {0}", Book1.tac_gia);
//        Console.WriteLine("The loai: {0}", Book1.the_loai);
//        Console.WriteLine("Ma sach: {0}", Book1.ma_sach);

//        /* in cac thong tin cua Book2 */
//        Console.WriteLine("\nIn thong tin cua cuon sach 2:");
//        Console.WriteLine("Ten sach: {0}", Book2.ten_sach);
//        Console.WriteLine("Tac gia: {0}", Book2.tac_gia);
//        Console.WriteLine("The loai: {0}", Book2.the_loai);
//        Console.WriteLine("Ma sach: {0}", Book2.ma_sach);

//        Console.ReadKey();
//    }
//}




//struct SinhVien
//{
//    public int MSSV;
//    public string HoTen;
//    public double DiemToan;
//    public double DiemLy;
//    public double DiemAnh;
//};
//public class test
//{
//    static void NhapThongTinSinhVien( out SinhVien SV)//Sử dụng từ khoá out để có thể cập nhật giá trị
//                                                      //nhập được ra biến SV1 bên ngoài 
//                                                     // khi kết thúc gọi hàm
//    {
//        Console.Write("ma so: ");
//        SV.MSSV = int.Parse(Console.ReadLine());
//        Console.Write("Ho va Ten: ");
//        SV.HoTen = Console.ReadLine();
//        Console.Write("Diem Toan: ");
//        SV.DiemToan = double.Parse(Console.ReadLine());
//        Console.Write("Diem Ly: ");
//        SV.DiemLy = double.Parse(Console.ReadLine());
//        Console.Write("ma so: ");
//        SV.DiemAnh = double.Parse(Console.ReadLine());
//    }

//    static void XuatThongTinSinhVien(SinhVien SV)
//    {
//        Console.WriteLine("ma so: " + SV.MSSV);
//        Console.WriteLine("Ho Ten: " + SV.HoTen);
//        Console.WriteLine("Diem Toan: " + SV.DiemToan);
//        Console.WriteLine("Diem Ly: " + SV.DiemLy);
//        Console.WriteLine("Diem Anh: " + SV.DiemAnh);
//    }
//    static double DiemTB(SinhVien SV)
//    {
//        return (SV.DiemToan + SV.DiemLy + SV.DiemAnh) / 3;
//    }
//    static void Main(string[] args)
//    {
//        SinhVien SV1 = new SinhVien();
//        Console.WriteLine("nhap thong tin sinh vien: ");

//        NhapThongTinSinhVien(out SV1);
//        Console.WriteLine("_________________________");
//        Console.WriteLine("Thong tin cua sinh vien la: ");
//        XuatThongTinSinhVien(SV1);
//        Console.WriteLine("Diem tb cua Sinh vien la: " + DiemTB(SV1));

//        Console.ReadKey();

//    }
//}


//su dung truong static trong struct
//struct Sum
//{
//    public static int x = 45;
//    public static int y = 78;
//}
//public class tinhtong
//{
//    public static void Main() {
//        int sum = Sum.x + Sum.y;
//        Console.WriteLine("tong cu hai so x va y la: " + sum);
//        Console.ReadLine();
//    }
//}


/*Viết chương trình C# để tạo một struct được lồng trong struct khác.
Ví dụ: một struct lưu giữ thông tin của nhân viên gồm
tên và ngày, tháng, năm sinh của nhân viên,
trong đó ngày, tháng, năm sinh của nhân viên được tạo bởi một struct khác.*/

struct NhanVien
{
    public string Name;
    public DateOfBirth Date ;
}
struct DateOfBirth {
    public int date;
    public int month;
    public int year;
}

public class ThongTinNV {
    public static void Main(string[] args) 
    {
        int dd=0, mm=0, yy = 0;
        int total = 2;
        NhanVien[] NV = new NhanVien[total];

        for (int i = 0; i < total; i++)
        {
            Console.Write("Ten nhan vien: ");
            string nm = Console.ReadLine();
            NV[i].Name = nm;

            Console.Write("ngay sinh: ");
            dd = int.Parse(Console.ReadLine());
            NV[i].Date.date = dd;

            Console.Write("thang sing: ");
            mm = int.Parse(Console.ReadLine());
            NV[i].Date.month = mm;

            Console.Write("nam sinh: ");
            yy = int.Parse(Console.ReadLine());
            Console.WriteLine();
            NV[i].Date.year = yy;

        }
        Console.ReadLine();
    }
}