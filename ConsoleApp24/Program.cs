using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Выберите задание: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №1");

                            double G, e, f, y;

                            Console.Write("Введите е: ");
                            e = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите f: ");
                            f = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            G = (Math.Pow(e, 2 * y) / (Math.Log(3.8 * y + f)));

                            Console.WriteLine($"G = {G}");

                            Console.ReadKey();
                        }
                        break;

                    case "2":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №2");

                            double d, y;

                            Console.Write("Введите d: ");
                            d = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine($"F = {Math.Log(d) + 3.5 * (Math.Pow(d, 2) + 1) / (Math.Cos(2 * y))}");

                            Console.ReadKey();
                        }
                        break;

                    case "3":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №3");

                            double e, y, k;

                            Console.Write("Введите e: ");
                            e = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите k: ");
                            k = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine($"U = {(Math.Log(k - y) + Math.Pow(y, 4)) / (Math.Pow(e, y) + 2.355 * k)}");

                            Console.ReadKey();
                        }
                        break;

                    case "4":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №4");

                            double w, y;

                            Console.Write("Введите e: ");
                            w = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите k: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine($"G = {9.33 * (Math.Pow(w, 3) + Math.Sqrt(w)) / (Math.Log(y + 3.5) + Math.Sqrt(y))}");

                            Console.ReadKey();
                        }
                        break;

                    case "5":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №5");

                            double e, y, a, t;

                            Console.Write("Введите e: ");
                            e = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите a: ");
                            a = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите t: ");
                            t = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine($"D = {(7.8 * Math.Pow(a, 2) + 3.52 * t) / (Math.Log(a + (2 * y)) + Math.Pow(e, y))}");

                            Console.ReadKey();
                        }
                        break;

                    case "6":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №6");

                            double i, y;

                            Console.Write("Введите e: ");
                            i = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine($"L = {(0.81 * Math.Cos(i)) / (Math.Log(y) + 2 * Math.Pow(2, i))}");

                            Console.ReadKey();
                        }
                        break;

                    case "7":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №7");

                            double m, y;

                            Console.Write("Введите m: ");
                            m = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine($"N = {(Math.Pow(m, 2) + 2.8 * m + 0.355) / (Math.Cos(2) * y + 3.6)}");

                            Console.ReadKey();
                        }
                        break;

                    case "8":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №8");

                            double t, y;

                            Console.Write("Введите e: ");
                            t = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine($"T = {(2.37 * Math.Sin(t + 1)) / (Math.Sqrt(4 * Math.Pow(y, 2) - 0.1 * y + 5))}");

                            Console.ReadKey();
                        }
                        break;

                    case "9":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №9");

                            double y, w;

                            Console.Write("Введите y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите w: ");
                            w = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine($"V = {(Math.Pow(y + 2 * w, 3)) / (Math.Log(y + 0.75))}");

                            Console.ReadKey();
                        }
                        break;

                    case "10":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №10");

                            double y, t;

                            Console.Write("Введите y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите t: ");
                            t = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine($"Z = {(2 * t + y * Math.Cos(t)) / (Math.Sqrt(y + 4.831))}");

                            Console.ReadKey();
                        }
                        break;

                    case "11":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №11");

                            double y, n;

                            Console.Write("Введите y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите n: ");
                            n = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine($"D = {Math.Pow(y, 2) + (0.5 * n + 4.8) / (Math.Sin(y))}");

                            Console.ReadKey();
                        }
                        break;

                    case "12":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №12");

                            double y, t;

                            Console.Write("Введите y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите t: ");
                            t = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine($"R = {(Math.Sin(Math.Pow((2 * t + 1), 2)) + 0.3) / Math.Log(t + y)}");

                            Console.ReadKey();
                        }
                        break;

                    case "13":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №13");

                            double y, e, h;

                            Console.Write("Введите y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите h: ");
                            h = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите e: ");
                            e = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine($"A = {(Math.Sin(2 * y + h) + Math.Pow(h, 2)) / (Math.Pow(e, h) + y)}");

                            Console.ReadKey();
                        }
                        break;

                    case "14":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №14");

                            double y, e, h;

                            Console.Write("Введите y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите h: ");
                            h = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите e: ");
                            e = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine($"P = {Math.Pow(e, (y + 2.5) + Math.Pow((7.1 * h), 2)) / (Math.Log(Math.Sqrt(y + 0.04 * h)))}");

                            Console.ReadKey();
                        }
                        break;

                    case "15":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №15");

                            double y, j;

                            Console.Write("Введите y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите j: ");
                            j = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine($"F = {(2 * Math.Sin(0.354 * y + 1)) / (Math.Log(y + 2 * j))}");

                            Console.ReadKey();
                        }
                        break;

                    case "16":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №16");

                            double t, e, r, y;

                            Console.Write("Введите t: ");
                            t = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите r: ");
                            r = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите e: ");
                            e = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine($"W = {(4 * Math.Pow(t, 3) + Math.Log(r)) / Math.Pow(e, (y + r)) + 7.2 * Math.Sin(r)}");

                            Console.ReadKey();
                        }
                        break;


                    case "17":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №17");

                            double y, n;

                            Console.Write("Введите y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите n: ");
                            n = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine($"H = {(Math.Pow(y, 2) - 0.8 * y + Math.Sqrt(y)) / (23.1 * Math.Pow(n, 2) + Math.Cos(n))}");

                            Console.ReadKey();
                        }
                        break;

                    case "18":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №18");

                            double y, k;

                            Console.Write("Введите y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите k: ");
                            k = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine($"R = {(Math.Sqrt(Math.Pow(Math.Sin(y), 2) + 6.835)) / ((Math.Log(y + k) + 3 * Math.Pow(y, 2)))}");

                            Console.ReadKey();
                        }
                        break;

                    case "19":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №19");

                            double y, q;

                            Console.Write("Введите y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите q: ");
                            q = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine($"E = {(Math.Log(0.7 * y + 2 * q)) / Math.Sqrt((3 * Math.Pow(y, 2) + 0.5 * y + 4))}");

                            Console.ReadKey();
                        }
                        break;

                    case "20":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №20");

                            double t, l, y, e;

                            Console.Write("Введите t: ");
                            t = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите l: ");
                            l = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите e: ");
                            e = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine($"K = {(2 * Math.Pow(t, 2) + 3 * l + 7.2) / (Math.Log(y + Math.Pow(e, 2 * t)))}");

                            Console.ReadKey();
                        }
                        break;

                    case "21":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №21");

                            double k, p, x, d;

                            Console.Write("Введите k: ");
                            k = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите p: ");
                            p = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите x: ");
                            x = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите d: ");
                            d = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine($"Q = {(Math.Sqrt(k + 2.6 * p * Math.Sin(k))) / (x - Math.Pow(d, 3))}");

                            Console.ReadKey();
                        }
                        break;

                    case "22":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №22");

                            double y, t;

                            Console.Write("Введите y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите t: ");
                            t = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine($"S = {(4.351 * Math.Pow(y, 3) + 2 * t * Math.Log(t)) / (Math.Sqrt(Math.Cos(2 * y) + 4.351))}");

                            Console.ReadKey();
                        }
                        break;

                    case "23":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №23");

                            double y, e, d;

                            Console.Write("Введите y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите e: ");
                            e = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите d: ");
                            d = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine($"R = {(Math.Sin(Math.Pow(y, 2) + 0.3 * d)) / (Math.Pow(e, y) + Math.Log(d))}");

                            Console.ReadKey();
                        }
                        break;


                    case "24":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №24");

                            double k, e, y;

                            Console.Write("Введите y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите e: ");
                            e = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите k: ");
                            k = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine($"U = {(Math.Log(2 * k + 4.3)) / (Math.Pow(e, k + y) + Math.Sqrt(y))}");

                            Console.ReadKey();
                        }
                        break;

                    case "25":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №25");

                            double c, t;

                            Console.Write("Введите c: ");
                            c = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите t: ");
                            t = Convert.ToDouble(Console.ReadLine());


                            Console.WriteLine($"L = {Math.Cos(Math.Pow(c, 2)) + (3 * Math.Pow(t, 3) + 3) / Math.Sqrt(c + t)}");

                            Console.ReadKey();
                        }
                        break;

                    case "26":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №26");

                            double u, y;

                            Console.Write("Введите y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите u: ");
                            u = Convert.ToDouble(Console.ReadLine());


                            Console.WriteLine($"T = {(Math.Sin(2 * u)) / (Math.Log(2 * y + u))}");

                            Console.ReadKey();
                        }
                        break;

                    case "27":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №27");

                            double p, y;

                            Console.Write("Введите y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите t: ");
                            p = Convert.ToDouble(Console.ReadLine());


                            Console.WriteLine($"Z = {Math.Sin(Math.Pow((p + 0.4), 2)) / (Math.Pow(y, 2) + 7.325 * p)}");

                            Console.ReadKey();
                        }
                        break;

                    case "28":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №28");

                            double v, y, e;

                            Console.Write("Введите y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите v: ");
                            v = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите e: ");
                            e = Convert.ToDouble(Console.ReadLine());

                        }
                        break;

                    case "29":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №29");

                            double h, y, e;

                            Console.Write("Введите y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите h: ");
                            h = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите e: ");
                            e = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine($"T = {(0.355 * Math.Pow(h, 2) - 4.355) / (Math.Pow(e, y + h) + Math.Sqrt(2.7 * y))}");

                            Console.ReadKey();
                        }
                        break;

                    case "30":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №30");

                            double p, y, e;

                            Console.Write("Введите y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите p: ");
                            p = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите e: ");
                            e = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine($"N = {(3 * Math.Pow(y, 2) + Math.Sqrt(y + 1)) / (Math.Log(p + y) + Math.Pow(e, p))}");

                            Console.ReadKey();
                        }
                        break;


                    default:
                        Console.WriteLine("Выберите корректное задание!");
                        Thread.Sleep(3000);
                        break;
                }
            }
        }
    }
}
