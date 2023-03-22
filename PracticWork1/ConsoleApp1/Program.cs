using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Globalization;
using System.Linq;
using Microsoft.VisualBasic;
using SystemException = System.SystemException;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Task1();
        }

        static void Task1()
        {
            string jew = "";
            string stone = "";
            stone = Console.ReadLine();
            jew = Console.ReadLine();
            int count = 0;

            for (int i = 0; i < stone.Length; ++i)
            {
                for (int j = 0; j < jew.Length; ++j)
                {
                    if (jew[j] == stone[i])
                    {
                        ++count;
                    }
                }
            }

            Console.WriteLine(count);
        }
        static bool NextSet(int[] digits, int length, int index)
        {
            for (int i = index - 1; i >= 0; --i)
            {
                if (digits[i] < length - index + i)
                {
                    ++digits[i];
                    for (int j = i + 1; j < index; ++j)
                    {
                        digits[j] = digits[j - 1] + 1;
                    }

                    return true;
                }
            }

            return false;
        }

        static bool isUnnessary(List<int[]> result, int[] array, int target)
        {
            foreach (int[] temp in result)
            {
                for (int i = 0; i < temp.Length; ++i)
                {
                    if (i == temp.Length - 1 && temp[i] == array[i])
                    {
                        return true;
                    }
                    if (temp[i] == array[i])
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            int sum = 0;
            for (int i = 0; i < array.Length; ++i)
            {
                sum += array[i];
            }
            if (sum != target)
            {
                return true;
            }
            return false;
        }

        static int[] Func(int[] input)
        {
            int[] temp = new int[input.Length];
            for (int i = 0; i < input.Length; ++i)
            {
                temp[i] = input[i];
            }
            return temp;
        }

        static void Task2()
        {
            string line = "";
            Console.Write("candidates = ");
            line = Console.ReadLine();
            int target = 0;
            Console.Write("target = ");
            target = Convert.ToInt32(Console.ReadLine());
            string[] candidatesString = line.Split(",");
            int[] candidates = new int [candidatesString.Length];
            List<int[]> result = new List<int[]> {};
            int index = 0;

            for (int i = 0; i < candidatesString.Length; ++i)
            {
                try
                {
                    candidates[i] = Convert.ToInt32(candidatesString[i]);
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Вы ввели не целочисленное число!!! {candidatesString[i]}");
                }

            }

            Array.Sort(candidates);

            for (int i = 1; i <= candidates.Length; ++i)
            {
                int[] digits = new int[i];
                for (int j = 0; j < i; ++j)
                {
                    digits[j] = j;
                }

                if (candidates.Length >= i)
                {
                    int[] temp = new int[i];
                    do
                    {
                        for (int j = 0; j < digits.Length; ++j)
                        {
                            temp[j] = candidates[digits[j]];
                        }

                        int[] temp2 = new int[i];
                        temp2 = Func(temp);

                        if (!isUnnessary(result, temp2, target))
                        {
                            result.Add(temp2);
                        }
                    } while (NextSet(digits, candidates.Length, i));
                }
            }

            for (int i = 0; i < result.Count; ++i)
            {
                Console.WriteLine(string.Join(" ", result[i]));
            }
        }

        static bool isHaveRepet(List<int> nums)
        {
            for (int i = 0; i < nums.Count - 1; ++i)
            {
                for (int j = i + 1; j < nums.Count; ++j)
                {
                    if (nums[i] == nums[j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        static void Task3()
        {
            string[] numsStr = Console.ReadLine().Split(",");
            List<int> nums = new List<int>();
            for (int i = 0; i < numsStr.Length; ++i)
            {
                try
                {
                    nums.Add(Convert.ToInt32(numsStr[i]));
                }
                catch (SystemException)
                {
                    Console.WriteLine("Вы ввели не целочисленное число!!! ");
                }
            }
            Console.WriteLine(isHaveRepet(nums));
        }
    }
}
