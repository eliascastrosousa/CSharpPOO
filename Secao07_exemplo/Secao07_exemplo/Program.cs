using System;
using System.Globalization;

namespace Secao07_exemplo {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Digite \n" +
                "[1] para operação ternaria\n" +
                "[2] Funções para String: \n" +
                "[3] Funções de Time \n" +
                "[4] Funções TimeSpan\n" +
                "[5] Propriedades e Operações com DateTime\n" +
                "[6] Formatação (DateTime -> string)\n" +
                "[7] Operações com Datetime (Add)\n" +
                "[8] Operações e propriedades com Timespan\n" +
                "[9] DateTimeKind e padrão ISO 8601 \n"+
                "[0] Sair: ");

            int n = int.Parse(Console.ReadLine());

            switch (n)
            {
                case 0: 
                    Console.WriteLine("Saindo..");
                    break;
                case 1:
                    Console.WriteLine("operação ternaria!");
                    Console.Write("Digite um valor: ");
                    double valor = double.Parse(Console.ReadLine());

                    double desconto = (valor <= 20) ? valor * 0.1 : valor * 0.05;
                    Console.WriteLine("Desconto: "+ desconto);
                    break;
                case 2:
                    Console.WriteLine("Funções para String!");
                    string original = "abcde FGHIJ ABC abc DEFG ";
                    string s1 = original.ToUpper();
                    string s2 = original.ToLower();
                    string s3 = original.Trim();
                    int n1 = original.IndexOf("bc");
                    int n2 = original.LastIndexOf("bc");
                    string s4 = original.Substring(3);
                    string s5 = original.Substring(3, 5);
                    string s6 = original.Replace('a', 'x');
                    string s7 = original.Replace("abc", "xy");
                    bool b1 = String.IsNullOrEmpty(original);
                    bool b2 = String.IsNullOrWhiteSpace(original);
                    Console.WriteLine("Original: -" + original + "-");
                    Console.WriteLine("ToUpper: -" + s1 + "-");
                    Console.WriteLine("ToLower: -" + s2 + "-");
                    Console.WriteLine("Trim: -" + s3 + "-");
                    Console.WriteLine("IndexOf('bc'): " + n1);
                    Console.WriteLine("LastIndexOf('bc'): " + n2);
                    Console.WriteLine("Substring(3): -" + s4 + "-");
                    Console.WriteLine("Substring(3, 5): -" + s5 + "-");
                    Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");
                    Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");
                    Console.WriteLine("IsNullOrEmpty: " + b1);
                    Console.WriteLine("IsNullOrWhiteSpace: " + b2);

                    break;

                case 3:
                    DateTime d1 = new DateTime();
                    DateTime d2 = new DateTime(2022, 03, 18); //ano mes dia
                    DateTime d3 = new DateTime(2022, 03, 18, 14, 01, 59); //ano mes dia
                    DateTime d4 = DateTime.Now;
                    DateTime d5 = DateTime.Today;


                    Console.WriteLine("Data zerada: " +d1);
                    Console.WriteLine("Data escrita manualmente Ano, Mês e Dia: "+d2);
                    Console.WriteLine("Data escrita manualmente Ano, Mês e Dia e hora " + d3);
                    Console.WriteLine("Data e hora atual do computador: "+ d4);
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

                    break;
                case 4:
                    Console.WriteLine("construtores\n================\n");
                    TimeSpan t1 = new TimeSpan();
                    TimeSpan t2 = new TimeSpan(900000000L);
                    TimeSpan t3 = new TimeSpan(2, 11, 21);
                    TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
                    TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);
                    Console.WriteLine(t1);
                    Console.WriteLine(t2);
                    Console.WriteLine(t3);
                    Console.WriteLine(t4);
                    Console.WriteLine(t5);

                    Console.WriteLine("métodos From\n================\n");

                    TimeSpan t6 = TimeSpan.FromDays(1.5);
                    TimeSpan t7 = TimeSpan.FromHours(1.5);
                    TimeSpan t8 = TimeSpan.FromMinutes(1.5);
                    TimeSpan t9 = TimeSpan.FromSeconds(1.5);
                    TimeSpan t10 = TimeSpan.FromMilliseconds(1.5);
                    TimeSpan t11 = TimeSpan.FromTicks(900000000L);
                    Console.WriteLine(t6);
                    Console.WriteLine(t7);
                    Console.WriteLine(t8);
                    Console.WriteLine(t9);
                    Console.WriteLine(t10);
                    Console.WriteLine(t11);

                    break;
                case 5:
                    Console.WriteLine("Propriedades e Operações com DateTime\n================\n");
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

                    

                    break;
                case 6:
                    Console.WriteLine("Formatação (DateTime -> string)");
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
                    break;
                case 7:
                    Console.WriteLine("Operações com Datetime");
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

                    break;
                case 8:
                    Console.WriteLine("MaxValue, MinValue, Zero");

                    TimeSpan tx = TimeSpan.MaxValue;
                    TimeSpan ty = TimeSpan.MinValue;
                    TimeSpan tz = TimeSpan.Zero;
                    Console.WriteLine(tx);
                    Console.WriteLine(ty);
                    Console.WriteLine(tz);

                    Console.WriteLine("Propriedades");

                    TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);
                    Console.WriteLine(t);
                    Console.WriteLine("Days: " + t.Days);
                    Console.WriteLine("Hours: " + t.Hours);
                    Console.WriteLine("Minutes: " + t.Minutes);
                    Console.WriteLine("Milliseconds: " + t.Milliseconds);
                    Console.WriteLine("Seconds: " + t.Seconds);
                    Console.WriteLine("Ticks: " + t.Ticks);
                    Console.WriteLine("TotalDays: " + t.TotalDays);
                    Console.WriteLine("TotalHours: " + t.TotalHours);
                    Console.WriteLine("TotalMinutes: " + t.TotalMinutes);
                    Console.WriteLine("TotalSeconds: " + t.TotalSeconds);
                    Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds);

                    Console.WriteLine("Operações");

                    TimeSpan ta = new TimeSpan(1, 30, 10);
                    TimeSpan tb = new TimeSpan(0, 10, 5);
                    TimeSpan sum = ta.Add(tb);
                    TimeSpan dif = ta.Subtract(tb);
                    TimeSpan mult = tb.Multiply(2.0);
                    TimeSpan div = tb.Divide(2.0);
                    Console.WriteLine(ta);
                    Console.WriteLine(tb);
                    Console.WriteLine(sum);
                    Console.WriteLine(dif);
                    Console.WriteLine(mult);
                    Console.WriteLine(div);
                    break;

                case 9:
                    Console.WriteLine("DateTimeKind");
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

                    Console.WriteLine("padrão ISO 8601");
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
                    break;

            }
            

            


        }

    }
            
}