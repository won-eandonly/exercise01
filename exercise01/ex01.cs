﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGUYENQUYNHNAMPHUONG_31231027650_24C1INF50900503
{
    public class Session_01
    {
        public static void Main()
        {
            //question01()
            //question02()
            //question03()
            //question04()
            //question05()
            //question06()
            //question07()
            //question08()
            //question09()
            //question10()
            Console.ReadKey();
        }
        public static void question01()
        {
            //cộng 2 số
            Console.Write("Nhap so a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b: ");
            int b = int.Parse(Console.ReadLine());
            int c = a + b;
            Console.WriteLine($"Tong 2 so la: {a}+{b}={c}");
        }
        public static void question02()
        {
            //đổi chỗ 2 giá trị
            Console.Write("Nhap vao gia tri x: ");
            string x = Console.ReadLine();
            Console.Write("Nhap vao gia tri y: ");
            string y = Console.ReadLine();
            string z;
            z = x; x = y; y = z;
            Console.WriteLine($"Gia tri x sau khi doi la: {x}");
            Console.WriteLine($"Gia tri y sau khi doi la: {y}");
        }
        public static void question03()
        {
            //nhân 2 số
            Console.Write("Nhap vao so a: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Nhap vao so b: ");
            float b = float.Parse(Console.ReadLine());
            float c = a * b;
            Console.WriteLine($"Tich 2 so la: {a}*{b}={c}");
        }
        public static void question04()
        {
            //đổi feet sang meter 
            Console.Write("Nhap so feet: ");
            double feet = float.Parse(Console.ReadLine());
            double meter = feet * 0.3048;
            Console.WriteLine($"Ket qua chuyen: {meter} meters");
        }
        public static void question05()
        {
            //chuyển độ C sang độ F và ngược lại
            Console.Write("Nhap do C: ");
            double doc = double.Parse(Console.ReadLine());
            double dof = doc * 9 / 5 + 32;
            Console.WriteLine($"Ket qua la: {doc}°C = {dof}°F");
            Console.Write("Nhap do F: ");
            double f = double.Parse(Console.ReadLine());
            double c = (f - 32) * 5 / 9;
            Console.WriteLine($"Ket qua la: {f}°F = {c}°C");
        }
        public static void question06()
        {
            //kích thước của kiểu dữ liệu
            Console.WriteLine("Kich thuoc cua kieu du lieu int la: " + sizeof(int));
            Console.WriteLine("Kich thuoc cua kieu du lieu char la: " + sizeof(char));
            Console.WriteLine("Kich thuoc cua kieu du lieu float la: " + sizeof(float));
            Console.WriteLine("Kich thuoc cua kieu du lieu double la: " + sizeof(double));
        }
        public static void question07()
        {
            //kí tự mã ASCII
            Console.Write("Nhap ki tu: ");
            char k = Console.ReadKey().KeyChar;
            Console.WriteLine();
            int ascii = (int)k;
            Console.WriteLine($"Gia tri cua {k} trong bang ASCII la {ascii}");
        }

        public static void question08()
        {
            //diện tích hình tròn
            Console.Write("Ban kinh hinh tron: ");
            float a = float.Parse(Console.ReadLine());
            double S = a * a * 3.14;
            Console.WriteLine($"Dien tich hinh tron la: {S}");
        }
        public static void question09()
        {
            //diện tích hình vuông
            Console.Write("Canh hinh vuong: ");
            float x = float.Parse(Console.ReadLine());
            double S = x * x;
            Console.WriteLine($"Dien tich hinh vuong la: {S}");
        }
        public static void question10()
        {
            //chuyển ngày thành năm,tuần, ngày
            Console.Write("Nhap so ngay: ");
            int d = int.Parse(Console.ReadLine());
            int y = d / 365;
            int w = (d - y * 365) / 7;
            int ds = (d - y * 365) - (w * 7);
            Console.Write($"{d} ngay = {y} nam, {w} tuan,{ds} ngay");
        }
    }
}