using System;

namespace _14hwmethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
        //-Verilmiş iki ədədi toplayıb nəticəsini qaytaran metod
        static int Plus(int num1, int num2)
        {
            return num1 + num2;
        }
        //-Verilmiş ədədin kvadratını qaytaran metod
        static int Square(int num)
        {
            return num * num;
        }
        //-Verilmiş string dəyərində a hərfinin olub olmadığını qaytaran metod
        static bool Isa(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a')
                    return true;
            }
            return false;
        }
        //-Verilmiş ədədin rəqəmləri cəmini qaytaran metod
        static int NumPlus(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                int x = num % 10;
                sum += x;
                num = (num - x) / 10;
            }
            return sum;


        }
        //- Verilmiş 4 ədədin ortalamasını tapıq qaytaran metod
        static int Average(int num1, int num2, int num3, int num4)
        {
            return (num1 + num2 + num3 + num4) / 4;
        }
        //-Verilmiş ədədin verilmiş qüvvətini tapan metod 
        static int Power(int num1, int num2)
        {
            int power = 1;
            for (int i = 0; i < num2; i++)
            {
                power *= num1;
            }
            return power;
        }
        //- Verilmiş 3 ədəddən ən böyüyünü tapan metod
        static int Biggest(int num1, int num2, int num3)
        {
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    return num1;
                }
                else
                {
                    return num3;
                }
            }
            else
            {
                if (num2 > num3)
                {
                    return num2;
                }
                else
                {
                    return num3;
                }
            }
        }
        //- Verilmiş ədədlər siyahısındaki ədədlərin cəmini tapan metod
        static int PlusArray(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum;
        }
        //  -Verilmiş ədədlər siyahısındaki ən böyük ədədi tapan metod
        static int BiggestArray(int[] nums)
        {
            int numsfirst = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > numsfirst)
                {
                    numsfirst = nums[i];
                }
            }
            return numsfirst;
        }
        // - Verilmiş ədədlər siyahısındaki ən böyük ədədin yerləşdiyi index - i qaytaran metod
        static int BiggestIndex(int[] numbers)
        {
            int index = 0;
            int numsfirst = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > numsfirst)
                {
                    numsfirst = numbers[i];
                    index = i;
                }
            }
            return index;
        }
        // -Verilmiş yazılar siyahısındaki(string array) verilmiş yazının yerləşdiyi indexi qaytaran metod.
        static int FindIndex(string[] words, string word)
        {
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == word)
                {
                    return i;
                }
            }
            return -1;
        }
        // - Verilmiş ədədlər siyahısındaki ədədlərin yalnız müsbət olanlarından ibarət yeni bir array qaytaran metod.Yəni metodu işə salın { 4,-5,3,-2,6}
        static int[] MakenewArray(int[] nums)
        {
            var count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    count++;
                }
            }
            int[] makenewarray = new int[count];
            int j = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    makenewarray[j] = nums[i];
                    j++;
                }
            }
            return makenewarray;
        }
        static int FindIndex(char[] words, char word)
        {
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == word)
                {
                    return i;
                }
            }
            return -1;
        }
        //-Verilmiş yazıda rəqəm olub olmadığını qaytaran metod
        static bool IsDigit(char yazi)
        {
            char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            return (FindIndex(numbers, yazi) != -1);

        }
        //-Verilmiş yazılar siyahısında neçə yazıda rəqəm olduğunu qaytaran metod
        static int IsDigitStr(string yazi)
        {
            int count = 0;
            for (int i = 0; i < yazi.Length; i++)
            {

                if (IsDigit(yazi[i]))
                {
                    count++;
                }
            }
            return count;

        }
        //Verilmiş yazıdaki ilk boşluq olmayan index-i qaytaran metod
        static int FirstNonSpace(string word)
        {
            for (int i = 0; i <= word.Length; i++)
            {
                if (word[i] != ' ')
                {
                    return i;
                }
            }
            return -1;
        }
        //Verilmiş yazıdaki son boşluq olmayan index-i qaytaran metod
        static int LastNonSpace(string word)
        {
            for (int i = word.Length - 1; i > 0; i--)
            {
                if (word[i] != ' ')
                {
                    return i;
                }
            }
            return -1;
        }
        //Verilmiş yazını sol tərəfində boşluq olmayan vəziyyətdə qaytaran metod
        static string TrimLeft(string word)
        {
            var NewStr = "";
            for (int i = FirstNonSpace(word); i < word.Length; i++)
            {
                NewStr += word[i];
            }
            return NewStr;

        }
        //Verilmiş yazını sol və sağ tərəflərində boşluq olmayan vəziyyətdə qaytaran metod
        static string TrimRightandLeft(string word)
        {
            var NewStr = "";
            for (int i = FirstNonSpace(word); i < word.Length; i++)
            {
                NewStr += word[i];
            }
            var NewestStr = "";
            for (int i = LastNonSpace(NewStr); i >= 0; i--)
            {
                NewestStr += NewStr[i];
            }
            var FinalStr = "";
            for (int i = LastNonSpace(NewestStr); i >= 0; i--)
            {
                FinalStr += NewestStr[i];
            }
            return FinalStr;

        }
    }
}
