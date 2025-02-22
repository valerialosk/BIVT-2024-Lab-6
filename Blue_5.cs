using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class Blue_5
    {
        public struct Sportsman
        {
            //поля
            private string _name;
            private string _surname;
            private int _place;
            //свойства
            public string Name { get { return _name; } }
            public string Surname { get { return _surname; } }
            public int Place { get { return _place; } }
            //конструктор 
            public Sportsman(string name, string surname)
            {
                _name = name;
                _surname = surname;
                _place = 0;
            }
            //методы
            public void SetPlace(int place)
            {
                if (_place != 0) return;
                _place = place;
            }
            public void Print()
            {
                Console.WriteLine($"{_name} {_surname} {_place}");
            }
        }
        public struct Team
        {
            //поля
            private string _name;
            private Sportsman[] _sportsman;
            private int _count;
            //свойства 
            public string Name { get { return _name; } }
            public Sportsman[] Sportsman
            {
                get
                {
                    if (_sportsman == null || _sportsman.Length == 0) return null;
                    Sportsman[] copy = new Sportsman[_sportsman.Length];
                    for (int i = 0; i < _sportsman.Length; i++)
                    {
                        copy[i] = _sportsman[i];
                    }
                    return copy;
                }
            }
            public int Count { get { return _count; } }
            public int SummaryScore
            {
                get
                {
                    if (_sportsman == null || _sportsman.Length == 0) return 0;
                    int sum = 0;
                    for (int i = 0; i < _sportsman.Length; i++)
                    {
                        if (_sportsman[i].Place == 1) sum += 5;
                        else if (_sportsman[i].Place == 2) sum += 4;
                        else if (_sportsman[i].Place == 3) sum += 3;
                        else if (_sportsman[i].Place == 2) sum += 2;
                        else if (_sportsman[i].Place == 1) sum += 1;
                    }
                    return sum;
                }
            }
            public int TopPlace
            {
                get
                {
                    if (_sportsman == null || _sportsman.Length == 0) return 0;
                    int maxPlace = int.MaxValue;
                    for (int i = 0; i < _sportsman.Length; i++)
                    {
                        if (_sportsman[i].Place > 0 && _sportsman[i].Place < maxPlace) maxPlace = _sportsman[i].Place;
                    }
                    return maxPlace;
                }
            }

            //конструктор 
            public Team (string name)
            {
                _name = name;
                _sportsman = new Sportsman[6];
                _count = 0;
            }
            //методы
            public void Add(Sportsman sportsman)
            {
                if (_sportsman == null || _sportsman.Length == 0 || _count >= _sportsman.Length) return;
                _sportsman[_count] = sportsman;
                _count++;
            }
            public void Add(Sportsman[] sportsman)
            {
                if (_sportsman.Length == 0 || _sportsman == null || sportsman == null || sportsman.Length == 0 || _count >= _sportsman.Length) return;
                int i = 0;
                while (_count < _sportsman.Length && i < sportsman.Length)
                {
                    _sportsman[_count] = sportsman[i];
                    _count++;
                    i++;
                }
            }
            public static void Sort(Team[] teams)
            {
                if (teams == null || teams.Length == 0) return;
                for (int i = 1, j = 2; i < teams.Length;)
                {
                    if (i == 0 || teams[i - 1].SummaryScore > teams[i].SummaryScore)
                    {
                        i = j;
                        j++;
                    }
                    else if (teams[i - 1].SummaryScore == teams[i].SummaryScore && teams[i - 1].TopPlace <= teams[i].TopPlace)
                    {
                        i = j;
                        j++;
                    }
                    else
                    {
                        Team temp = teams[i];
                        teams[i] = teams[i - 1];
                        teams[i - 1] = temp;
                        i--;
                    }
                }
            }
            public void Print()
            {
                for (int i = 0; i < _sportsman.Length; i++)
                {
                    Console.WriteLine($"{_name} {SummaryScore} {TopPlace}");
                }
            }
        }
    }
}
