using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class Blue_3
    {
        public struct Participant
        {
            //поля
            private string _name;
            private string _surname;
            public int[] _penaltyTimes;
            //свойства 
            public string Name { get { return _name; } }
            public string Surname { get { return _surname; } }
            public int[] PenaltyTimes
            {
                get
                {
                    if (_penaltyTimes == null || _penaltyTimes.Length == 0) return null;
                    int[] copy = new int[_penaltyTimes.Length];
                    for (int i = 0; i < copy.Length; i++)
                    {
                        copy[i] = _penaltyTimes[i];
                    }
                    return copy;
                }
            }
            public int TotalTime
            {
                get
                {
                    if (_penaltyTimes == null || _penaltyTimes.Length == 0) return 0;
                    int count = 0; 
                    for (int i = 0; i < _penaltyTimes.Length;i++)
                    {
                        count += _penaltyTimes[i];
                    }
                    return count;
                }
            }
            public bool IsExpelled
            {
                get
                {
                    if (_penaltyTimes == null || _penaltyTimes.Length == 0) return true;
                    bool t = false;
                    for (int i = 0; i < _penaltyTimes.Length; i++)
                    {
                        if (_penaltyTimes[i] == 10) return true;
                    }
                    return t;
                }
            }
            //конструктор
            public Participant(string name, string surname)
            {
                _name = name;
                _surname = surname;
                _penaltyTimes = null;
            }
            //методы 
            public void PlayMatch(int time)
            {
                if (_penaltyTimes == null || _penaltyTimes.Length == 0)
                {
                    int[] _pT = new int[1];
                    _pT[0] = time;
                    _penaltyTimes = _pT;
                }
                else
                {
                    int[] pT = new int[_penaltyTimes.Length + 1];
                    pT[pT.Length - 1] = time;
                    for (int i = 0; i < _penaltyTimes.Length;i++)
                    {
                        pT[i] = _penaltyTimes[i];
                    }
                    _penaltyTimes = pT;
                }
            }
            public void Print()
            {
                Console.WriteLine($"{this._name} {this._surname} {this.TotalTime} {this.IsExpelled}");
            }
        }
    }
}
