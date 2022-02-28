using System;
using System.Collections.Generic;
using System.Text;

namespace P127.HW._24._02
{
    class Student
    {
        private string _fullname;
        private string _groupno;
        public string Fullname
        {
            get
            {
                return _fullname;
            }
            set
            {
                if (GetCheckFullName(value))
                {
                    _fullname = value;
                }
            }
        }
        public string GroupNo {
            get
            {
                return _groupno;
            }
            set
            {
                if (CheckGroupNo(value))
                {
                    _groupno = value;
                }
            }
        }
        public int Age;

        public Student(string fullname, string groupno, int age)
        {
            Fullname = fullname;
            GroupNo = groupno;
            Age = age;
        }

        public static bool GetCheckFullName(string fullname)
        {

            string[] arr = fullname.Split();
            if (arr.Length==2)
            {
                for (int i = 0; i < arr[0].Length; i++)
                {
                    if (Char.IsLetter(arr[0][i]))
                    {
                        return true;
                    }
                }
                for (int i = 0; i < arr[1].Length; i++)
                {
                    if (Char.IsLetter(arr[1][i]))
                    {
                        return true;
                    }
                }
                if (Char.IsUpper(arr[0][0]) && Char.IsUpper(arr[1][0]))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool CheckGroupNo(string no)
        {
            
            if (no.Length==4)
            {
                if (Char.IsUpper(no[0]))
                {
                    if (char.IsDigit(no[1])&& char.IsDigit(no[2])&& char.IsDigit(no[3]))
                    {
                        return true;
                    }
                }
            }
            return false;
            
        }


    }
}
