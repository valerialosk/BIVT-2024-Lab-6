using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab_6.Blue_1;
using static Lab_6.Blue_2;

namespace Lab_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            //Blue_1
            /*Blue_1.Response response0 = new Blue_1.Response("Даниил", "Гурьянов");
            Blue_1.Response response1 = new Blue_1.Response("Степан", "Животов");
            Blue_1.Response response2 = new Blue_1.Response("Николай", "Золотарев");
            Blue_1.Response response3 = new Blue_1.Response("Сергей", "Бутов");
            Blue_1.Response[] responses = new Blue_1.Response[] { response0, response1, response2, response3 };
            response0.CountVotes(responses);
            response1.CountVotes(responses);
            response2.CountVotes(responses);
            response3.CountVotes(responses);
            response0.Print();
            response1.Print();
            response2.Print();
            response3.Print();*/
            //Blue_2
            /*Blue_2.Participant participant0 = new Blue_2.Participant("Александр", "Петров");
            int[] result01 = new int[5] { 11, 0, 8, 7, 1 };
            int[] result02 = new int[5] { 2, 3, 10, 13, 16};
            participant0.Jump(result01);
            participant0.Jump(result02);
            Blue_2.Participant participant1 = new Blue_2.Participant("Артем", "Луговой");
            int[] result11 = new int[5] { 18, 17, 20, 7, 11 };
            int[] result12 = new int[5] { 3, 7, 12, 19, 2 };
            participant1.Jump(result11);
            participant1.Jump(result12);
            Blue_2.Participant participant2 = new Blue_2.Participant("Мария", "Свиридова");
            int[] result21 = new int[5] { 17, 13, 2, 19, 2 };
            int[] result22 = new int[5] { 10, 0, 0, 6, 5 };
            participant2.Jump(result21);
            participant2.Jump(result22);
            Blue_2.Participant participant3 = new Blue_2.Participant("Игорь", "Смирнов");
            int[] result31 = new int[5] { 15, 7, 14, 19, 15};
            int[] result32 = new int[5] { 5, 13, 16, 19, 16 };
            participant3.Jump(result31);
            participant3.Jump(result31);
            Blue_2.Participant[] participants= new Blue_2.Participant[] {participant0, participant1, participant2, participant3};
            Blue_2.Participant.Sort(participants);
            for (int i = 0; i < participants.Length; i++)
            {
                participants[i].Print();
            }*/
            //Blue_3
            /*Blue_3.Participant participant0 = new Blue_3.Participant("Инна", "Пономарева");
            participant0.PlayMatch(2);
            participant0.PlayMatch(2);
            participant0.PlayMatch(0);
            participant0.PlayMatch(2);
            participant0.PlayMatch(0);
            participant0.PlayMatch(0);
            participant0.PlayMatch(0);
            participant0.PlayMatch(5);
            participant0.PlayMatch(2);
            participant0.PlayMatch(5);
            participant0.Print();
            Blue_3.Participant participant1 = new Blue_3.Participant("Дмитрий", "Иванов");
            participant1.PlayMatch(0);
            participant1.PlayMatch(10);
            participant1.PlayMatch(10);
            participant1.PlayMatch(0);
            participant1.PlayMatch(5);
            participant1.PlayMatch(5);
            participant1.PlayMatch(2);
            participant1.PlayMatch(10);
            participant1.PlayMatch(10);
            participant1.PlayMatch(10);
            participant1.Print();
            Blue_3.Participant participant2 = new Blue_3.Participant("Дарья", "Павлова");
            participant2.PlayMatch(2);
            participant2.PlayMatch(5);
            participant2.PlayMatch(5);
            participant2.PlayMatch(2);
            participant2.PlayMatch(0);
            participant2.PlayMatch(10);
            participant2.PlayMatch(5);
            participant2.PlayMatch(2);
            participant2.PlayMatch(0);
            participant2.PlayMatch(0);
            participant2.Print();
            Blue_3.Participant participant3 = new Blue_3.Participant("Дарья", "Лисицына");
            participant3.PlayMatch(2);
            participant3.PlayMatch(10);
            participant3.PlayMatch(2);
            participant3.PlayMatch(5);
            participant3.PlayMatch(2);
            participant3.PlayMatch(2);
            participant3.PlayMatch(10);
            participant3.PlayMatch(10);
            participant3.PlayMatch(5);
            participant3.PlayMatch(0);
            participant3.Print();*/
            //Blue_4
            /*Blue_4.Team team0 = new Blue_4.Team("Энергия");
            team0.PlayMatch(1);
            team0.PlayMatch(0);
            team0.PlayMatch(0);
            team0.PlayMatch(0);
            team0.PlayMatch(3);
            team0.PlayMatch(0);
            team0.PlayMatch(1);
            team0.PlayMatch(0);
            team0.PlayMatch(1);
            team0.PlayMatch(3);
            team0.PlayMatch(0);
            team0.PlayMatch(0);
            Blue_4.Team team1 = new Blue_4.Team("Спартак");
            team1.PlayMatch(0);
            team1.PlayMatch(0);
            team1.PlayMatch(1);
            team1.PlayMatch(3);
            team1.PlayMatch(3);
            team1.PlayMatch(1);
            team1.PlayMatch(0);
            team1.PlayMatch(3);
            team1.PlayMatch(0);
            team1.PlayMatch(3);
            team1.PlayMatch(1);
            team1.PlayMatch(3);
            team1.PlayMatch(3);
            team1.PlayMatch(0);
            team1.PlayMatch(1);
            team1.PlayMatch(1);
            team1.PlayMatch(1);
            team1.PlayMatch(1);
            team1.PlayMatch(0);
            team1.PlayMatch(1);
            Blue_4.Team team2 = new Blue_4.Team("Барс");
            team2.PlayMatch(0);
            team2.PlayMatch(3);
            team2.PlayMatch(0);
            team2.PlayMatch(0);
            team2.PlayMatch(3);
            team2.PlayMatch(1);
            team2.PlayMatch(0);
            team2.PlayMatch(1);
            team2.PlayMatch(0);
            team2.PlayMatch(3);
            team2.PlayMatch(0);
            team2.PlayMatch(0);
            team2.PlayMatch(3);
            team2.PlayMatch(1);
            team2.PlayMatch(1);
            team2.PlayMatch(3);
            team2.PlayMatch(0);
            team2.PlayMatch(1);
            team2.PlayMatch(0);
            team2.PlayMatch(0);
            Blue_4.Team team3 = new Blue_4.Team("Русь");
            team3.PlayMatch(1);
            team3.PlayMatch(1);
            team3.PlayMatch(1);
            team3.PlayMatch(3);
            team3.PlayMatch(0);
            team3.PlayMatch(3);
            team3.PlayMatch(3);
            team3.PlayMatch(0);
            team3.PlayMatch(3);
            team3.PlayMatch(3);
            team3.PlayMatch(3);
            team3.PlayMatch(1);
            Blue_4.Group group1 = new Blue_4.Group("Группа 1");
            Blue_4.Group group2 = new Blue_4.Group("Группа 2");
            group1.Add(team0);
            group1.Add(team1);
            group2.Add(team2);
            group1.Add(team3);
            group1.Sort();
            group2.Sort();
            Blue_4.Group result = Blue_4.Group.Merge(group1, group2, 4);
            result.Print();*/
            //Blue_5
            /*Blue_5.Sportsman sport0 = new Blue_5.Sportsman("Мирослав", "Распутин");
            sport0.SetPlace(12);
            Blue_5.Sportsman sport1 = new Blue_5.Sportsman("Игорь", "Павлов");
            sport1.SetPlace(2);
            Blue_5.Sportsman sport2 = new Blue_5.Sportsman("Полина", "Свиридова");
            sport2.SetPlace(17);
            Blue_5.Sportsman sport3 = new Blue_5.Sportsman("Савелий", "Луговой");
            sport3.SetPlace(13);
            Blue_5.Sportsman sport4 = new Blue_5.Sportsman("Николай", "Козлов");
            sport4.SetPlace(5);
            Blue_5.Sportsman sport5 = new Blue_5.Sportsman("Юлия", "Сидорова");
            sport5.SetPlace(6);
            Blue_5.Sportsman sport6 = new Blue_5.Sportsman("Полина", "Луговая");
            sport6.SetPlace(7);
            Blue_5.Sportsman sport7 = new Blue_5.Sportsman("Светлана", "Иванова");
            sport7.SetPlace(8);
            Blue_5.Sportsman sport8 = new Blue_5.Sportsman("Александр", "Петров");
            sport8.SetPlace(9);
            Blue_5.Sportsman sport9 = new Blue_5.Sportsman("Игорь", "Распутин");
            sport9.SetPlace(10);
            Blue_5.Sportsman sport10 = new Blue_5.Sportsman("Савелий", "Свиридов");
            sport10.SetPlace(11);
            Blue_5.Sportsman sport11 = new Blue_5.Sportsman("Мария", "Свиридова");
            sport11.SetPlace(1);
            Blue_5.Sportsman sport12 = new Blue_5.Sportsman("Дмитрий", "Свиридов");
            sport12.SetPlace(4);
            Blue_5.Sportsman sport13 = new Blue_5.Sportsman("Светлана", "Козлова");
            sport13.SetPlace(14);
            Blue_5.Sportsman sport14 = new Blue_5.Sportsman("Екатерина", "Луговая");
            sport14.SetPlace(15);
            Blue_5.Sportsman sport15 = new Blue_5.Sportsman("Степан", "Жарков");
            sport15.SetPlace(16);
            Blue_5.Sportsman sport16 = new Blue_5.Sportsman("Степан", "Распутин");
            sport16.SetPlace(3);
            Blue_5.Sportsman sport17 = new Blue_5.Sportsman("Дарья", "Свиридова");
            sport17.SetPlace(18);
            Blue_5.Team group1 = new Blue_5.Team("Локомотив");
            Blue_5.Team group2 = new Blue_5.Team("Динамо");
            Blue_5.Team group3 = new Blue_5.Team("Спартак");
            group1.Add(sport0);
            group1.Add(sport1);
            group1.Add(sport2);
            group1.Add(sport3);
            group1.Add(sport4);
            group1.Add(sport5);
            group2.Add(sport6);
            group2.Add(sport7);
            group2.Add(sport8);
            group2.Add(sport9);
            group2.Add(sport10);
            group2.Add(sport11);
            group3.Add(sport12);
            group3.Add(sport13);
            group3.Add(sport14);
            group3.Add(sport15);
            group3.Add(sport16);
            group3.Add(sport17);
            group1.Print();
            group2.Print();
            group3.Print();*/
            Blue_4.Team[] teams = new Blue_4.Team[]            {
                new Blue_4.Team("Энергия"),
                new Blue_4.Team("Спартак"),
                new Blue_4.Team("Барс"),
                new Blue_4.Team("Нефтехим"),
                new Blue_4.Team("Байкал"),
                new Blue_4.Team("Василек"),
                new Blue_4.Team("Урал"),
                new Blue_4.Team("Быки"),
                new Blue_4.Team("Метеор"),
                new Blue_4.Team("Быки"),
                new Blue_4.Team("ЦСКА"),
                new Blue_4.Team("Русь")            };
            foreach (var x in new int[] { 1, 0, 0, 0, 3, 0, 1, 0, 1, 3, 0, 0 }) teams[0].PlayMatch(x);
            foreach (var x in new int[] { 0, 0, 1, 3, 3, 1, 0, 3, 0, 3, 1, 3, 3, 0, 1, 1, 1, 1, 0, 1 }) teams[1].PlayMatch(x);
            foreach (var x in new int[] { 0, 3, 0, 0, 3, 1, 0, 1, 0, 3, 0, 0, 3, 1, 1, 3, 0, 1, 0, 0 }) teams[2].PlayMatch(x);
            foreach (var x in new int[] { 3, 1, 1, 0, 1, 0, 1, 3, 1, 3, 1, 0, 1, 1, 0, 1, 3, 3, 3, 0 }) teams[3].PlayMatch(x);
            foreach (var x in new int[] { 1, 0, 1, 0, 0, 1, 3, 1, 3, 3, 3, 1, 3, 3, 0, 1, 0, 0, 0, 0 }) teams[4].PlayMatch(x);
            foreach (var x in new int[] { 1, 3, 3, 3, 3, 3, 1, 3, 3, 0, 1, 3, 3, 0, 1, 0, 0, 3, 0, 3 }) teams[5].PlayMatch(x);
            foreach (var x in new int[] { 0, 1, 3, 1, 1, 0, 0, 0, 3, 3, 1, 3, 3, 3, 0, 0, 3, 3, 3, 0 }) teams[6].PlayMatch(x);
            foreach (var x in new int[] { 3, 3, 1, 0, 3, 3, 0, 3, 3, 3, 1, 0 }) teams[7].PlayMatch(x);
            foreach (var x in new int[] { 3, 0, 0, 0, 0, 1, 3, 0, 0, 3, 0, 3 }) teams[8].PlayMatch(x);
            foreach (var x in new int[] { 3, 0, 0, 3, 3, 1, 3, 1, 3, 1, 3, 1 }) teams[9].PlayMatch(x);
            foreach (var x in new int[] { 0, 0, 0, 1, 1, 3, 1, 0, 1, 0, 0, 0 }) teams[10].PlayMatch(x);
            foreach (var x in new int[] { 0, 0, 0, 1, 1, 3, 1, 0, 1, 0, 0, 0 }) teams[11].PlayMatch(x);
            Blue_4.Group group1 = new Blue_4.Group("Группа 1");
            foreach (var team in teams)
            {
                group1.Add(team);
            }
            group1.Sort();
            Console.WriteLine("Группа 1 после сортировки:"); group1.Print();

            Console.WriteLine();
            Blue_4.Team[] teamss = new Blue_4.Team[] {
        new Blue_4.Team("Локомотив"),
        new Blue_4.Team("СКА"),
        new Blue_4.Team("Энергия"),
        new Blue_4.Team("Нефтехим"),
        new Blue_4.Team("Ак-барс"),
        new Blue_4.Team("Барс"),
        new Blue_4.Team("СПБ"),
        new Blue_4.Team("Быки"),
        new Blue_4.Team("Метеор"),
        new Blue_4.Team("Быки"),
        new Blue_4.Team("ЦСКА"),
        new Blue_4.Team("Русь") };

            foreach (var x in new int[] { 1, 1, 3, 0, 3, 0, 1, 0, 3, 3, 3, 3 }) teamss[0].PlayMatch(x);
            foreach (var x in new int[] { 0, 0, 1, 0, 3, 1, 0, 3, 1, 3, 1, 3, 3, 1, 1, 1, 0, 3, 1, 1 }) teamss[1].PlayMatch(x);
            foreach (var x in new int[] { 1, 1, 3, 3, 0, 0, 3, 3, 1, 0, 3, 0, 0, 1, 0, 3, 1, 1, 0, 1 }) teamss[2].PlayMatch(x);
            foreach (var x in new int[] { 1, 3, 3, 1, 1, 3, 3, 1, 3, 3, 1, 1, 0, 3, 0, 3, 1, 3, 1, 1 }) teamss[3].PlayMatch(x);
            foreach (var x in new int[] { 0, 3, 1, 1, 1, 0, 3, 1, 0, 3, 0, 0, 1, 3, 3, 1, 1, 3, 0, 0 }) teamss[4].PlayMatch(x);
            foreach (var x in new int[] { 3, 1, 0, 0, 3, 1, 0, 1, 3, 0, 0, 1, 3, 0, 0, 0, 3, 0, 3, 1 }) teamss[5].PlayMatch(x);
            foreach (var x in new int[] { 0, 1, 1, 3, 0, 1, 3, 0, 3, 3, 0, 0, 0, 3, 3, 1, 1, 0, 3, 1 }) teamss[6].PlayMatch(x);
            foreach (var x in new int[] { 3, 3, 1, 0, 3, 3, 0, 3, 3, 3, 1, 0 }) teamss[7].PlayMatch(x);
            foreach (var x in new int[] { 3, 0, 0, 0, 0, 1, 3, 0, 0, 3, 0, 3 }) teamss[8].PlayMatch(x);
            foreach (var x in new int[] { 3, 0, 0, 3, 3, 1, 3, 1, 3, 1, 3, 1 }) teamss[9].PlayMatch(x);
            foreach (var x in new int[] { 0, 0, 0, 1, 1, 3, 1, 0, 1, 0, 0, 0 }) teamss[10].PlayMatch(x);
            foreach (var x in new int[] { 1, 1, 1, 3, 0, 3, 3, 0, 3, 3, 3, 1 }) teamss[11].PlayMatch(x);
            Blue_4.Group group2 = new Blue_4.Group("Группа 2");
            foreach (var team in teamss)
            {
                group2.Add(team);
            }
            group2.Sort();
            Console.WriteLine("Группа 2 после сортировки:"); group2.Print();
            Blue_4.Group.Merge(group1, group2, 12).Print();
        }
    }
}
       
