using System;

namespace ngay2_8
{
    class Program
    {

        ////vẽ một hình chữ nhật rỗng NxM
        static void Main(string[] args)
        {
            //    //for loop
            

        //    int m = 20;
        //    int n = 10;
        //    char drawChar = '@';
        //    char insideChar = ' ';
        //    for (int i = 0; i < n; i++)
        //    {
        //        for (int j = 0; j < m; j++) {
        //            /*
        //             * Nếu đang ở tọa độ là cạnh trên hoặc dưới i % (N - 1) == 0
        //             * hoặc đang ở cạnh trái hoặc phải (j % (M - 1) == 0)
        //             * mà không nằm ở cạnh trên hoặc dưới (i % (N - 1) != 0)
        //             * ((i % (N - 1) != 0) && (j % (M - 1) == 0))
        //             * thì vẽ ra ký tự của hình chữ nhật
        //             * ngược lại vẽ ra ký tự không thuộc hình chữ nhật
        //            */
        //            if(i % (n - 1) == 0||(i % (n - 1) != 0) && (j % (m - 1) == 0))
        //                {
        //                    Console.Write(drawChar);

        //                }
        //            else 
        //                 {

        //                     Console.Write(insideChar);
        //                 }
        //        }
        //        //ve xong 1 hang thi xuong dong
        //        Console.WriteLine();

        //    }
        //    Console.ReadLine();




        //tinh tong 10 so tu nhien dau tien


        //    int j, sum = 0;

        //    Console.Write("\n");
        //        Console.Write("Tinh tong day so trong C#:\n");
        //        Console.Write("-----------------------------");
        //        Console.Write("\n\n");
        //        Console.Write("Nhap n: ");
        //        //n = Convert.ToInt32(Console.Read());
        //        //Console.Write("n so tu nhien dau tien la:\n");
        //        for (j = 1; j <= 10; j++)
        //        {

        //            Console.Write("{0} ",j);
        //            sum = sum + j;
        //        }
        //Console.Write("\nTong cua n so tren la: {0}\n", sum);            

        //        Console.ReadKey();




        ////tim so nguyen to:
        //public static void Main()
        //{
        //    int num, i, ctr, start, end;

        //    Console.Write("\n\n");
        //    Console.Write("Tim so nguyen to trong C#:\n");
        //    Console.Write("--------------------------");
        //    Console.Write("\n\n");

        //    Console.Write("Nhap so bat dau cua day: ");
        //    start = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("Nhap so ket thuc cua day: ");
        //    end = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Cac so nguyen to trong day tu {0} den {1} la:", start, end);

        //    for (num = start; num <= end; num++)
        //    {
        //        ctr = 0;

        //        for (i = 2; i <= num / 2; i++)
        //        {
        //            if (num % i == 0)
        //            {
        //                ctr++;
        //                break;
        //            }
        //        }

        //        if (ctr == 0 && num != 1)
        //            Console.Write("{0} ", num);


        //    }
        //    Console.Write("\n");

        //    Console.ReadKey();




        //while loop

        //static void Main(string[] args)
        //{ 
        //    int countLoop = 0;
        //    int countLoopTime = 0;
        //    int valueNum = 6;
        //    int loopTime = 20;

        //    //ve tu tren xuong loopTime lan
        //    while (countLoopTime < loopTime)
        //    {
        //        countLoop = 0;//reset ve 0 de ve lai tu dau
        //        while (countLoop < valueNum) {
        //            // in ra giá trị của countLoop trong 8 vị trí
        //            Console.Write("{0,8}", countLoop);
        //            countLoop++;

        //        }
        //        Console.WriteLine();
        //        countLoopTime++;

        //    }
        //    Console.ReadLine();



        //bien toan cuc va bien cuc bo

        //    static int a = 5;
        //    static void Main(string[] args)
        //    {
        //        Console.WriteLine(a);
        //        a = 10;
        //        printSN();
        //        Console.ReadKey();

        //    }
        //    static void printSN()
        //    {
        //        int a = 9;
        //        Console.WriteLine(a);
        //    }



        //mang mot chieu
        //sap xep mang theo thu tu tang dan, 

        //int[] arr = new int[20];
        //int i, j, n, tg;
        //Console.Write("nhap kich thuoc mang ");
        //n = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("nhap {0} phan tu vao mang: ", n);
        //for (i = 0; i < n; i++)
        //{
        //    Console.Write("phan tu {0} la: ", i);
        //    arr[i] = Convert.ToInt32(Console.ReadLine());

        //}
        //for (i = 0; i < n; i++)
        //{
        //    for (j = 0; j < n; j++)
        //    {
        //        if (arr[j] > arr[i])
        //        {
        //            tg = arr[i];
        //            arr[i] = arr[j];
        //            arr[j] = tg;
        //        }
        //    }
        //}
        ////in mang theo thu tu tang dan:
        //Console.Write("mang sau khi sap xep la: ");
        //for (i = 0; i < n; i++)
        //{
        //    Console.Write("{0}  ", arr[i]);

        //}
        //Console.WriteLine();
        //Console.ReadLine();



        /*  //mang 2 chieu
         *  
          //viết chương trình cho phép nhập vào giá trị số nguyên cho 1 mảng 2 chiều bất kỳ sau đó
          //in ra màn hình mảng đã nhập kèm theo tổng tất cả các giá trị trong mảng.
          static void Main(string[] args)
          {
              Console.Write("nhap so hang cua ma tran: ");
              int Rows = Int32.Parse(Console.ReadLine());
              Console.Write("nhap so cot cua ma tran: ");
              int Colunms = Int32.Parse(Console.ReadLine());

              //tao mang 2 chieu m hang, n cot
              int[,] Matran = new int[Rows, Colunms];
              for (int i = 0; i < Matran.GetLength(0); i++)//GetLength(0): so dong
              {
                  for (int j = 0; j < Matran.GetLength(1); j++)//GetLength(1): so cot
                  {
                      Console.Write("nhap phan tu Matran[{0},{1}]= ", i, j);
                      Matran[i, j] = int.Parse(Console.ReadLine());
                  }

              }
              //in mang 2 chieu:
              Console.WriteLine("ma tran ban vua nhap la: ");
              int Sum = 0;
              for (int i = 0; i < Matran.GetLength(0); i++)//GetLength(0): so dong
              {
                  for (int j = 0; j < Matran.GetLength(1); j++)//GetLength(1): so cot
                  {
                      Console.Write(Matran[i,j]+" ");
                      Sum = Sum + Matran[i, j];
                  }
                  Console.WriteLine();

              }
              Console.WriteLine("tong cac gia tri trong ma tran la: " + Sum);
        */




        ////tinh tong tren duong cheo chinh cua ma tran

        //int dem = 0;
        //int sum = 0;
        //Console.Write("nhap kich thuoc cua ma tran: ");
        //int n = Int32.Parse(Console.ReadLine());
        //int[,] arr = new int[n, n];
        //Console.WriteLine("nhap cac phan tu cua ma tran:");
        //for (int i = 0; i < arr.GetLength(0); i++)
        //{
        //    for (int j = 0; j < arr.GetLength(1); j++)
        //    {
        //        Console.Write("phan tu arr[{0},{1}]= ", i, j);
        //        arr[i, j] = int.Parse(Console.ReadLine());

        //        ////tinh sum
        //        //if (i == j)
        //        //{
        //        //    sum = sum + arr[i, j];
        //        //}


        //        //xet ma tran co phai ma tran thua ko(so phan to =0 > so phan tu khac 0)
        //        if (arr[i, j] == 0)
        //        {

        //            ++dem;
        //        }

        //    }
        //}
        //if (dem > ((n * n) / 2))
        //{
        //    Console.WriteLine("ma tran la ma tran thua!");
        //}
        //else {
        //    Console.WriteLine("ma tran ko la ma tran thua!");
        //}
        //Console.WriteLine("in ma tran: ");
        //for (int i = 0; i < arr.GetLength(0); i++)
        //{
        //    for (int j = 0; j < arr.GetLength(1); j++)
        //    {
        //        Console.Write(arr[i, j] + "   ");

        //    }
        //    Console.WriteLine();

        //}
        ////Console.WriteLine("tong cac phan tu tren duong cheo chinh la: {0}", sum);
        //Console.ReadLine();



        ////ham
        //PrintSomething("thu ", 22);
        //PrintSomething("DHXD ", 67);
        //Console.ReadLine();

        //static void PrintSomething(string name, int age) {
        //    Console.WriteLine("this is {0},{1} years old", name, age);
        //}

    }
    }
}
       