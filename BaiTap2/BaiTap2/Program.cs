// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentManagement
{
    public class Student
    {
        private int id;
        private string name;
        private int age;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    name = "Unknown";
                else
                    name = value;
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Tuoi khong hop le. Da gan mac dinh la 1.");
                    age = 1;
                }
                else
                {
                    age = value;
                }
            }
        }

        public Student() { }

        public Student(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        // In ra thong tin sinh vien
        public override string ToString()
        {
            return $"ID: {Id} | Ten: {Name} | Tuoi: {Age}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<Student> students = new List<Student>();

            Console.WriteLine("== QUAN LY HOC SINH ==");

            int n;
            while (true)
            {
                Console.Write("Nhap so luong hoc sinh (>= 5): ");
                if (int.TryParse(Console.ReadLine(), out n) && n >= 5)
                    break;
                Console.WriteLine("So luong phai la so nguyen va >= 5. Vui long nhap lai!");
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n--- Nhap hoc sinh thu {i + 1} ---");
                Student sv = new Student();

                Console.Write("Nhap ID: ");
                sv.Id = int.Parse(Console.ReadLine());

                Console.Write("Nhap Ten: ");
                sv.Name = Console.ReadLine();

                Console.Write("Nhap Tuoi: ");
                sv.Age = int.Parse(Console.ReadLine());

                students.Add(sv);
            }

            Console.WriteLine("\n===========================================");
            Console.WriteLine("KET QUA XU LY LINQ:");

            Console.WriteLine("\na. Danh sach toan bo hoc sinh:");
            students.ForEach(s => Console.WriteLine(s));

            Console.WriteLine("\nb. Hoc sinh co tuoi tu 15 den 18:");
            var age15to18 = students.Where(s => s.Age >= 15 && s.Age <= 18).ToList();
            if (age15to18.Any())
                age15to18.ForEach(s => Console.WriteLine(s));
            else
                Console.WriteLine("Khong co.");

            Console.WriteLine("\nc. Hoc sinh co ten bat dau bang chu 'A':");
            var nameA = students.Where(s => s.Name.Trim().StartsWith("A", StringComparison.OrdinalIgnoreCase)).ToList();
            if (nameA.Any())
                nameA.ForEach(s => Console.WriteLine(s));
            else
                Console.WriteLine("Khong co.");

            Console.WriteLine($"\nd. Tong tuoi cua tat ca hoc sinh: {students.Sum(s => s.Age)}");

            Console.WriteLine("\ne. Hoc sinh co tuoi lon nhat:");
            if (students.Any())
            {
                int maxAge = students.Max(s => s.Age);
                students.Where(s => s.Age == maxAge).ToList().ForEach(s => Console.WriteLine(s));
            }

            Console.WriteLine("\nf. Danh sach sap xep theo tuoi tang dan:");
            students.OrderBy(s => s.Age).ToList().ForEach(s => Console.WriteLine(s));

            Console.ReadLine();
        }
    }
}