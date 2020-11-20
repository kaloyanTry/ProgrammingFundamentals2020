using System;
using System.Globalization;
using System.Linq;

namespace ArrayManipulator
{
    class ArrayManipulator
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();

                if (command[0] == "exchange")
                {
                    int indexNumbers = int.Parse(command[1]);

                    if (indexNumbers < 0 || indexNumbers > numbers.Length - 1)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    Exchange(numbers, indexNumbers);
                }
                else if (command[0] == "max")
                {
                    if (command[1] == "even")
                    {
                        if (MaxEven(numbers) == -1)
                        {
                            Console.WriteLine("No matches");
                            continue;
                        }
                        Console.WriteLine(MaxEven(numbers));
                    }
                    else
                    {
                        if (MaxOdd(numbers) == -1)
                        {
                            Console.WriteLine("No matches");
                            continue;
                        }
                        Console.WriteLine(MaxOdd(numbers));
                    }
                }
                else if (command[0] == "min")
                {
                    if (command[1] == "even")
                    {
                        if (MinEven(numbers) == -1)
                        {
                            Console.WriteLine("No matches");
                            continue;
                        }
                        Console.WriteLine(MinEven(numbers));
                    }
                    else
                    {
                        if (MinOdd(numbers) == -1)
                        {
                            Console.WriteLine("No matches");
                            continue;
                        }
                        Console.WriteLine(MinOdd(numbers));
                    }
                }
                else if (command[0] == "first")
                {
                    int count = int.Parse(command[1]);
                    if (count > numbers.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }

                    if (command[2] == "even")
                    {
                        ReturnFirstEven(numbers, count);
                    }
                    else
                    {
                        ReturnFirstOdd(numbers, count);
                    }
                }
                else if (command[0] == "last")
                {
                    int count = int.Parse(command[1]);
                    if (count > numbers.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }
                    if (command[2] == "even")
                    {
                        ReturnLastEven(numbers, count);
                    }
                    else
                    {
                        ReturnLastOdd(numbers, count);
                    }
                }
            }

            Console.WriteLine("[" + string.Join(", ", numbers) + "]");
        }

        static void Exchange(int[] array, int index)
        {
            int[] firstArr = new int[array.Length - index - 1];
            int[] secondArr = new int[index + 1];

            int firstArrCounter = 0;

            for (int i = index + 1; i < array.Length; i++)
            {
                firstArr[firstArrCounter] = array[i];
                firstArrCounter++;
            }

            for (int i = 0; i < index + 1; i++)
            {
                secondArr[i] = array[i];
            }
            for (int i = 0; i < firstArr.Length; i++)
            {
                array[i] = firstArr[i];
            }
            for (int i = 0; i < secondArr.Length; i++)
            {
                array[firstArr.Length + i] = secondArr[i];
            }
        }

        static int MaxEven(int[] array)
        {
            int maxEven = int.MinValue;
            int index = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    if (array[i] >= maxEven)
                    {
                        maxEven = array[i];
                        index = i;
                    }
                }
            }
            return index;
        }

        static int MaxOdd(int[] array)
        {
            int maxOdd = int.MinValue;
            int index = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    if (array[i] >= maxOdd)
                    {
                        maxOdd = array[i];
                        index = i;
                    }
                }
            }
            return index;
        }

        static int MinEven(int[] array)
        {
            int minEven = int.MaxValue;
            int index = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    if (array[i] <= minEven)
                    {
                        minEven = array[i];
                        index = i;
                    }
                }
            }
            return index;
        }

        static int MinOdd(int[] array)
        {
            int minOdd = int.MaxValue;
            int index = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    if (array[i] <= minOdd)
                    {
                        minOdd = array[i];
                        index = i;
                    }
                }
            }
            return index;
        }

        static void ReturnFirstEven(int[] array, int count)
        {
            string numbers = string.Empty;
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    numbers += array[i] + " ";
                    counter++;
                }

                if (counter == count)
                {
                    break;
                }
            }

            var result = numbers.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (counter == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine("[" + string.Join(", ", result) + "]");
            }
        }

        static void ReturnFirstOdd(int[] array, int count)
        {
            string numbers = string.Empty;
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    numbers += array[i] + " ";
                    counter++;
                }

                if (counter == count)
                {
                    break;
                }
            }

            string[] result = numbers.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (counter == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine("[" + string.Join(", ", result) + "]");
            }
        }

        static void ReturnLastEven(int[] array, int count)
        {
            string numbers = string.Empty;
            int counter = 0;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] % 2 == 0)
                {
                    counter++;
                    numbers += array[i] + " ";
                }
                if (counter == count)
                {
                    break;
                }
            }

            var result = numbers.Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse();
            if (counter == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine("[" + string.Join(", ", result) + "]");
            }
        }
        static void ReturnLastOdd(int[] array, int count)
        {
            string numbers = string.Empty;
            int counter = 0;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] % 2 != 0)
                {
                    counter++;
                    numbers += array[i] + " ";
                }
                if (counter == count)
                {
                    break;
                }
            }

            var result = numbers.Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse();
            if (counter == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine("[" + string.Join(", ", result) + "]");
            }
        }
    }
}
