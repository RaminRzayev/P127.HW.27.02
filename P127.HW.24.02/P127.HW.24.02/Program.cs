using System;

namespace P127.HW._24._02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Student student = new Student();
            student.Fullname = "emin Eyazov";
            Console.WriteLine(student.Fullname);*/
            /* student.GroupNo = "Pa24";
             Console.WriteLine(student.GroupNo);*/
            while (true)
            {
                Console.WriteLine("Ad ve Soyadi daxil edin:");
                string fullname = Console.ReadLine();
                if (Student.GetCheckFullName(fullname))
                {
                    continue;
                }
                Console.WriteLine("Qrupun No-ni daxil edin:");
                string groupno = Console.ReadLine();
                if (Student.CheckGroupNo(groupno))
                {
                    continue;
                }
                Console.WriteLine("Yasinizi daxil edin:");
                int age = Convert.ToInt32(Console.ReadLine());

                
                Student student = new Student(fullname, groupno, age);
                Console.WriteLine($"Ad ve Soyad: {student.Fullname}\nYas: {student.Age}\nQrup nomresi: {student.GroupNo}");
            } ;









        }
    }
}
