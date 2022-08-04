using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secao07_exemplo {
    internal class funcoesDateTime {
        public void funcDateTime() {
            DateTime d1 = new DateTime();
            DateTime d2 = new DateTime(2022, 03, 18); //ano mes dia
            DateTime d3 = new DateTime(2022, 03, 18, 14, 01, 59); //ano mes dia
            DateTime d4 = DateTime.Now;
            DateTime d5 = DateTime.Today;


            Console.WriteLine("Data zerada: " + d1);
            Console.WriteLine("Data escrita manualmente Ano, Mês e Dia: " + d2);
            Console.WriteLine("Data escrita manualmente Ano, Mês e Dia e hora " + d3);
            Console.WriteLine("Data e hora atual do computador: " + d4);
            Console.WriteLine("Só o data: " + d5 + "\n\n");

            Console.WriteLine("Usando o Parse: ");

            DateTime d6 = DateTime.Parse("10/01/1996 05:30:45");
            DateTime d7 = DateTime.Parse("10-01-1996");
            DateTime d8 = DateTime.Parse("10-01-1996 15:45");
            //DateTime d9 = DateTime.ParseExact("10-01-1996", "dd/MM/yyyy");
            Console.WriteLine(d6);
            Console.WriteLine(d7);
            Console.WriteLine(d8);
            //Console.WriteLine(d9);
        }
        public void propDateTime() {
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);
        }
        public void formatDateTime() {
            DateTime e = new DateTime(2001, 8, 15, 13, 45, 58);
            string s = e.ToLongDateString();
            string ss = e.ToLongTimeString();
            string sss = e.ToShortDateString();
            string y = e.ToShortTimeString();
            string yy = e.ToString();
            string yyy = e.ToString("yyyy-MM-dd HH:mm:ss");
            string z = e.ToString("yyyy-MM-dd HH:mm:ss.fff");
            Console.WriteLine(s);
            Console.WriteLine(ss);
            Console.WriteLine(sss);
            Console.WriteLine(y);
            Console.WriteLine(yy);
            Console.WriteLine(yyy);
            Console.WriteLine(z);
        }
        public void operationsDateTime() {
            DateTime x = new DateTime();
            //DateTime y = x.Add(20000000000000);
            DateTime a = x.AddDays(2);
            DateTime aa = x.AddHours(2);
            DateTime aaa = x.AddMilliseconds(240);
            DateTime aaaa = x.AddMinutes(5);
            DateTime aaaaa = x.AddMonths(1);
            DateTime aaaaaa = x.AddSeconds(35);
            DateTime aaaaaaa = x.AddTicks(900000000);
            DateTime aaaaaaaa = x.AddYears(3);
            //y = x.Subtract(timeSpan); //subtrair datas
            //TimeSpan t = x.Subtract(dateTime);

            Console.WriteLine(a);
            Console.WriteLine(aa);
            Console.WriteLine(aaa);
            Console.WriteLine(aaaa);
            Console.WriteLine(aaaaa);
            Console.WriteLine(aaaaaa);
            Console.WriteLine(aaaaaaa);
            Console.WriteLine(aaaaaaaa);
        }
        public void DateTimeKinds() {
            DateTime xx = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime ww = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime zz = new DateTime(2000, 8, 15, 13, 5, 58);
            Console.WriteLine("d1: " + xx);
            Console.WriteLine("d1 Kind: " + xx.Kind);
            Console.WriteLine("d1 to Local: " + xx.ToLocalTime());
            Console.WriteLine("d1 to Utc: " + xx.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d2: " + ww);
            Console.WriteLine("d2 Kind: " + ww.Kind);
            Console.WriteLine("d2 to Local: " + ww.ToLocalTime());
            Console.WriteLine("d2 to Utc: " + ww.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d3: " + zz);
            Console.WriteLine("d3 Kind: " + zz.Kind);
            Console.WriteLine("d3 to Local: " + zz.ToLocalTime());
            Console.WriteLine("d3 to Utc: " + zz.ToUniversalTime());
        }
        public void DateTimeISO8601() {
            DateTime de = DateTime.Parse("2000-08-15 13:05:58");
            DateTime df = DateTime.Parse("2000-08-15T13:05:58Z"); // cria local DateTime
            Console.WriteLine("d1: " + de);
            Console.WriteLine("d1 Kind: " + de.Kind);
            Console.WriteLine("d1 to Local: " + de.ToLocalTime());
            Console.WriteLine("d1 to Utc: " + de.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d2: " + df);
            Console.WriteLine("d2 Kind: " + df.Kind);
            Console.WriteLine("d2 to Local: " + df.ToLocalTime());
            Console.WriteLine("d2 to Utc: " + df.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine(df.ToString("yyyy-MM-ddTHH:mm:ssZ")); // cuidado!
            Console.WriteLine(df.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));
        }
    }
}
