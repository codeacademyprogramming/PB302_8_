using System;
using System.Text.RegularExpressions;

namespace homeworks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //1. Verilmiş 3 ədəddən hansının ən böyük olduğunu tapan proqram
            //Console.Write("1. ededi daxil edin: ");
            //string num1Str = Console.ReadLine();
            //int num1 = Convert.ToInt32(num1Str);

            //Console.Write("2. ededi daxil edin:");
            //string num2Str = Console.ReadLine();
            //int num2 = Convert.ToInt32(num2Str);

            //Console.Write("3. ededi daxil edin:");
            //string num3Str = Console.ReadLine();
            //int num3 = Convert.ToInt32(num3Str);

            //int biggest;
            //if (num1 > num2)
            //{
            //    if (num1 > num3)
            //        biggest = num1;
            //    else
            //        biggest = num3;
            //}
            //else if (num2 > num3)
            //    biggest = num2;
            //else biggest = num3;

            //Console.WriteLine($"En boyuk eded: {biggest}");
            #endregion

            #region Task2
            //Verilmiş yazının içində verilmis herfin olub olmadığını tapan proqram

            //Console.WriteLine("Yazini daxil edin:");
            //string text = Console.ReadLine();
            //Console.WriteLine("Axtarilan herfi daxil edin:");
            //string letterStr = Console.ReadLine();
            //char letter = Convert.ToChar(letterStr);

            //bool hasA = false;

            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (text[i] == letter)
            //    {
            //        hasA = true;
            //        break;
            //    }
            //}

            ////if (hasA == true) Console.WriteLine("A herfi var");
            //if (hasA) Console.WriteLine($"{letter} herfi var");
            //else Console.WriteLine($"{letter} herfi yoxdur");
            #endregion

            #region Task3
            //Verilmiş yazıda neçə A hərfinin olduğunu tapan proqram

            //Console.WriteLine("Yazini daxil edin:");
            //string text = Console.ReadLine();

            //int count = 0;

            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (text[i] == 'A')
            //        count++;
            //}

            //Console.WriteLine($"Yazida {count} sayda A herfi var");

            #endregion

            #region Task4
            //Verilmiş müsbət cüt ədədi kradtarına yüksəldən proqram.
            //Daxil edilən ədə musbət və cüt olmadıqca yenidən daxil edilməlidir


            //int num;
            //do
            //{
            //    Console.WriteLine("Ededi daxil edin:");
            //    string numStr = Console.ReadLine();
            //    num = Convert.ToInt32(numStr);
            //} 
            //while (num<=0 || num%2!=0);

            //int result = num * num;

            //Console.WriteLine($"Verilmis ededin kvadrati: {result}");

            #endregion

            #region Task5
            //Verilmiş ədədlər siyahısındaki ədədlərin cəmini tapan proqram

            //Console.WriteLine("Ededlerin sayini daxil edin:");
            //string numsCountStr = Console.ReadLine();
            //int numsCount = Convert.ToInt32(numsCountStr);

            //int[] nums = new int[numsCount];

            //string output = "";
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine($"{i+1}. ededi yaz");
            //    string numStr = Console.ReadLine();
            //    int num = Convert.ToInt32(numStr);
            //    nums[i] = num;


            //    if(i!=0 && num >=0)
            //        output += "+";
            //    output += numStr;
            //}

            //int sum = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    sum=sum+nums[i];
            //}

            //output += $"={sum}";
            //Console.WriteLine(output);
            #endregion

            #region Task6
            //Verilmiş təhsil növü dəyərinə əsasən o təhsilin saatını göstərən
            //proqram.Əgər verilmiş dəyər "programming"dirsə console-da
            //400 saat, "design"dırsa 250 saat, "system"dirsə 200 saat,
            //heç biri deyilsə "təhsil novu yanlisdir" yazılmalıdır console-da.
            bool checkInput;
            do
            {
                Console.WriteLine("Tehsil novunu daxil edin:");
                string educationType = Console.ReadLine();
                checkInput = true;

                switch (educationType)
                {
                    case "programming":
                        Console.WriteLine("400 saat");
                        break;
                    case "design":
                        Console.WriteLine("250 saat");
                        break;
                    case "system":
                        Console.WriteLine("200 saat");
                        break;
                    default:
                        checkInput = false;
                        Console.WriteLine("Tehsil novu yanlisdir");
                        break;
                }
            } while (!checkInput);


            #endregion
        }
    }
}
