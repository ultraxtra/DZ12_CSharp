using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using DZ11_CSharp;
using static System.Console;
namespace H_W._12._08
{
    public delegate List<int> ArryaDelegat(int[] arr);
    public delegate bool StringContains(string str, string word);

    internal class Program
    {
        static void Task1()
        {
            ShowRgb showRgb = new ShowRgb();
            showRgb.eventGetRgb += delegate (Color c)
            {
                return "RGB(" + c.R.ToString() + "," + c.G.ToString() + "," + c.B.ToString() + ")";
            };
            WriteLine(showRgb.GetRgb(Color.Red));
        }

        static void Task2()
        {
            try
            {
                Backpack backpack = new Backpack(15, "Black", 3, "LV", 10);
                Object object1 = new Object("Food", 9);
                Dispatcher dispatcher = new Dispatcher();
                dispatcher.addContent += delegate (Object content)
                {
                    backpack.CurrentSize += content.Size;
                    if (backpack.CurrentSize <= backpack.Size)
                    {
                        backpack.Content.Add(content);
                    }
                    else
                    {
                        throw new Exception("Size is out of range");
                    }
                };
                dispatcher.AddObject(object1);
                backpack.ShowContent();
            }catch(Exception ex)
            {
                WriteLine(ex.Message.ToString());
            }
           
        }

        static void Task3()
        {
            try
            {
                Dispatcher dispatcher = new Dispatcher();
                ArrayInt arrayInt = new ArrayInt(20);
                arrayInt.FillRandom(70);
                arrayInt.Show();
                WriteLine();
                WriteLine("Numbers are multiples of 7: ");
                dispatcher.arryaDelegat += (arrayInt) =>
                {
                    List<int> list = new List<int>();
                    int j = 0;
                    for (int i = 0; i < arrayInt.Length; i++)
                    {
                        if (arrayInt[i] % 7 == 0)
                        {
                            list.Add(arrayInt[i]);
                        }
                    }
                    return list;
                };
                List<int> Temp = dispatcher.SamplingFromArray(arrayInt.TestArr);
                foreach (int i in Temp)
                {
                    WriteLine(i.ToString());
                }
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message.ToString());
            }
        }
        static void Task4()
        {
            try
            {
                Dispatcher dispatcher = new Dispatcher();
                ArrayInt arrayInt = new ArrayInt(20);
                arrayInt.FillNegative(5);
                arrayInt.Show();
                WriteLine();
                WriteLine("Positive numbers: ");
                dispatcher.arryaDelegat += (arrayInt) =>
                {
                    List<int> list = new List<int>();
                    for (int i = 0; i < arrayInt.Length; i++)
                    {
                        if (arrayInt[i] > 0)
                        {
                            list.Add(arrayInt[i]);
                        }
                    }
                    return list;
                };
                List<int> Temp = dispatcher.SamplingFromArray(arrayInt.TestArr);
                foreach (int i in Temp)
                {
                    WriteLine(i.ToString());
                }
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message.ToString());
            }
        }
        static void Task5()
        {
            try
            {
                Dispatcher dispatcher = new Dispatcher();
                ArrayInt arrayInt = new ArrayInt(20);
                arrayInt.FillNegative(30);
                arrayInt.Show();
                WriteLine();
                WriteLine("Uniq numbers: ");
                dispatcher.arryaDelegat += (arrayInt) =>
                {
                    List<int> list = new List<int>();
                    for (int i = 0; i < arrayInt.Length; i++)
                    {
                        bool Chek = true;
                        for (int j = 0; j < arrayInt.Length; j++)
                        {
                            if (arrayInt[i] == arrayInt[j])
                            {
                                Chek = false;
                            }
                        }
                        if (Chek && arrayInt[i] < 0)
                        {
                            list.Add(arrayInt[i]);
                        }
                    }
                    return list;
                };
                List<int> Temp = dispatcher.SamplingFromArray(arrayInt.TestArr);
                foreach (int i in Temp)
                {
                    WriteLine(i.ToString());
                }
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message.ToString());
            }
        }
        static void Task6()
        {
            try
            {
                Dispatcher dispatcher = new Dispatcher();
                string Temp = "Together we can do so much!";
                dispatcher.stringContains += (string str, string word) =>
                {
                    if (str.Contains(word))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                };
                if (dispatcher.IsStringContaince(Temp, "do"))
                {
                    Console.WriteLine("Word found!");
                }
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message.ToString());
            }
        }
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            //Task4();
            //Task5();
            Task6();
        }
    }

    
}