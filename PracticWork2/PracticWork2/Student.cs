using System;

namespace PracticWork2
{
    public class Student
    {
        private string _surname;
        private DateTime _birthday;
        private int _group;
        private int[] _marks = new int[5];

        public string GetSurname => _surname;
        public string SetSurname
        {
            set => _surname = value;
        }

        public DateTime GetBirthday => _birthday;
        public DateTime SetBirthday
        {
            set => _birthday = value;
        }

        public int GetGroup => _group;
        public int SetGroup
        {
            set => _group = value;
        }

        public int[] GetMarks => _marks;
        public int[] SetMarks
        {
            set => _marks = value;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Студент: {_surname} из группы {_group}  ");
            Console.WriteLine($"Дата рождения {_birthday.ToString("dd.MM.yyyy")}");
            Console.WriteLine($"Оценки [ {string.Join(", ", _marks)} ]");
        }
    }
}