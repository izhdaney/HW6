using System;

namespace HW6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            //Task4();
            //Task5();
            //Task6();
            getResultTask7();

        }

        private static void Task1()
        {
            int [,] arr = getNewArray();

            arr = addArrayElement(arr);

            int minElemenet = getResultTask1(arr);

            foreach (var el in arr)
            {
                Console.Write($"{el}\t");
            }

            Console.WriteLine($"\nMin Element is {minElemenet}");
        }

        private static void Task2()
        {
            int[,] arr = getNewArray();

            arr = addArrayElement(arr);

            int maxElemenet = getResultTask2(arr);

            foreach (var el in arr)
            {
                Console.Write($"{el}\t");
            }

            Console.WriteLine($"\nMax Element is {maxElemenet}");
        }

        private static void Task3()
        {
            int[,] arr = getNewArray();

            arr = addArrayElement(arr);

            string minElemenet = getResultTask3(arr);

            foreach (var el in arr)
            {
                Console.Write($"{el}\t");
            }

            Console.WriteLine($"\n{minElemenet}");
        }

        private static void Task4()
        {
            int[,] arr = getNewArray();

            arr = addArrayElement(arr);

            string maxElemenet = getResultTask4(arr);

            foreach (var el in arr)
            {
                Console.Write($"{el}\t");
            }

            Console.WriteLine($"\n{maxElemenet}");
        }

        private static void Task5()
        {
            int[,] arr = getNewArray();

            arr = addArrayElement(arr);

            int count = getResultTask5(arr);

            foreach (var el in arr)
            {
                Console.Write($"{el}\t");
            }

            Console.WriteLine($"\n Count is {count}");
        }

        private static void Task6()
        {
            int number = numberReadTask6();

            string result = getResultTask6(number);

            Console.WriteLine($"Result is - {result}");


        }

        private static int getResultTask1(int [,] arr)
        {
            int minElement = arr[0, 0];

            foreach (var el in arr)
            {
                if (minElement > el)
                {
                    minElement = el;
                }
            }

            return minElement;
        }

        private static int getResultTask2(int[,] arr)


        {
            int maxElement = arr[0, 0];

            foreach (var el in arr)
            {
                if (maxElement < el)
                {
                    maxElement = el;
                }
            }

            return maxElement;
        }

        private static string getResultTask3(int[,] arr)


        {
            int minElement = arr[0, 0];

            var column = arr.GetLength(0);
            var row = arr.GetLength(1);

            int a = 0;
            int b = 0;

            

            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (minElement > arr[i,j])
                    {
                        minElement = arr[i, j];
                        a = i;
                        b = j;
                    }
                }
            }
            string result = $"Index min element array is [{a}, {b}]";

            return result;
        }

        private static string getResultTask4(int[,] arr)


        {
            int maxElement = arr[0, 0];

            var column = arr.GetLength(0);
            var row = arr.GetLength(1);

            int a = 0;
            int b = 0;



            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (maxElement < arr[i, j])
                    {
                        maxElement = arr[i, j];
                        a = i;
                        b = j;
                    }
                }
            }
            string result = $"Index max element array is [{a}, {b}]";

            return result;
        }

        private static int getResultTask5(int[,] arr)


        {
            int count = 0;

            var column = arr.GetLength(0);
            var row = arr.GetLength(1);



            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        if (arr[i,j] > arr[i, j + 1])
                        {
                            count++;
                        }
                    }
                    else if (i == column - 1 && j == row - 1)
                    {
                        if (arr[i, j] > arr[i, j - 1])
                        {
                            count++;
                        }
                    }
                    else if (j == row - 1)
                    {
                        if (arr[i, j - 1] < arr[i, j] && arr[i + 1, 0] < arr[i, j])
                        {
                            count++;
                        }
                    }
                    else if (j == 0)
                    {
                        if (arr[i - 1, row - 1] < arr[i, j] && arr[i, j + 1] < arr[i, j])
                        {
                            count++;
                        }
                    }
                    else
                    {
                        if (arr[i, j - 1] < arr[i, j] && arr[i, j + 1] < arr[i, j])
                        {
                            count++;
                        }
                    }
                }
            }

            return count;
        }

        private static int[,] getNewArray()
        {
            string columnMessage = "Please enter array column length - int > 0";
            string rowMessage = "Please enter array row length - int > 1";
            string errorMessage = "Invalid input. Integer value expected";
            int c = NaturalIntRead(columnMessage, errorMessage);
            int r = ArrayLengthRead(rowMessage, errorMessage);

            int[,] arr = new int[c, r];

            return arr;

        }

        private static int NaturalIntRead(string normalMessage, string errorMessage)
        {
            int returnValue;
            Console.WriteLine(normalMessage);
            do
            {
                string readValue = Console.ReadLine();
                if (int.TryParse(readValue, out returnValue) && returnValue > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(errorMessage);
                }
            } while (true);
            return returnValue;
        }

        private static int ArrayLengthRead(string normalMessage, string errorMessage)
        {
            int returnValue;
            Console.WriteLine(normalMessage);
            do
            {
                string readValue = Console.ReadLine();
                if (int.TryParse(readValue, out returnValue) && returnValue > 1)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(errorMessage);
                }
            } while (true);
            return returnValue;
        }

        private static int[,] addArrayElement(int [,] arr)
        {
            var column = arr.GetLength(0);
            var row = arr.GetLength(1);
            var r = new Random();

            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    arr[i, j] = r.Next(1, 50);
                }
            }

            return arr;
        }

        private static int numberReadTask6()
        {
            string normalMessage = "Please enter number (0-999)";
            string errorMessage = "Invalid input. Integer value expected";

            int returnValue;
            Console.WriteLine(normalMessage);
            do
            {
                string readValue = Console.ReadLine();
                if (int.TryParse(readValue, out returnValue) && returnValue >= 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(errorMessage);
                }
            } while (true);
            return returnValue;
        }

        private static string getResultTask6(int n)
        {
            string[] arr1 = new string[20] {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};
            string[] arr2 = new string[8] { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"};

            string result = "";

            if (n > 0 && n < 20)
            {
                result = $"{arr1[n]}";
            }
            else if (n < 99)
            {
                if (n % 10 == 0)
                {
                    int a = n / 10;
                    result = $"{arr2[a - 2]}";
                }
                else
                {
                    int a = n % 10;
                    int b = n / 10;
                    result = $"{arr2[b - 2]}-{arr1[a]}";
                }
            }
            else if (n == 100 || n == 200 || n == 300 || n == 400 || n == 500 || n == 600 || n == 700 || n == 800 || n == 900)
            {
                n = n / 100;
                result = $"{arr1[n]} hundred";
            }
            else if (n % 100 < 20)
            {
                int a = n % 100;
                int b = n / 100;

                result = $"{arr1[b]} hundred and {arr1[a]}";
            }
            else
            {
                if (n % 10 == 0)
                {
                    int a = n / 100;
                    n = n / 10;
                    int b = n % 10;
                    result = $"{arr1[a]} hundred and {arr2[b - 2]}";
                }
                else
                {
                    int c = n % 10;
                    n = n / 10;
                    int b = n % 10;
                    int a = n / 10;

                    result = $"{arr1[a]} hundred and {arr2[b - 2]}-{arr1[c]}";
                }
            }


            return result;
        }

        private static void getResultTask7()
        {
            //7.Вводим строку, которая содержит число, написанное прописью(0 - 999). Получить само число. 
            Console.WriteLine("Enter the input, which contains a number written in words (0 - 999).");
            string[] number = Console.ReadLine().Split(" ");

            int n = number.Length;

            int[] arrNum1 = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] arrNum2 = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            int[] arrNum3 = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] arrNum4 = new int[] { 0, 10, 20, 30, 40, 50, 60, 70, 80, 90 };
            int[] arrNum5 = new int[] {10, 11, 12, 13, 14, 15, 16, 17, 18, 19};

        string[] arr1 = new string[] {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};
            string[] arr2 = new string[] {"", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            string[] arr3 = new string[] { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};

            int a = 0;
            int b = 0;
            int c = 0;

            string result = "";

            if (n == 5)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (number[0] == arr1[i])
                    {
                        a = arrNum1[i];
                    }
                    if (number[3] == arr2[i])
                    {
                        b = arrNum1[i];
                    }
                    if (number[4] == arr1[i])
                    {
                        c = arrNum1[i];
                    }
                }
                result = $"{a}{b}{c}";
            }
            else if (n == 4) 
            {
                for (int i = 0; i < 10; i++)
                {
                    if (number[0] == arr1[i])
                    {
                        a = arrNum1[i];
                    }
                    if (number[3] == arr3[i])
                    {
                        b = arrNum2[i];
                        c = arrNum3[i];
                    }
                    else if (number[3] == arr2[i])
                    {
                        b = arrNum1[i];
                    }
                    else if (number[3] == arr1[i])
                    {
                        c = arrNum1[i];
                    }

                }
                result = $"{a}{b}{c}";
            }
            else if (n == 2)
            {
                if (number[1] == "hundred")
                {
                    for (int i = 0; i < 10; i++)
                    {
                        if (number[0] == arr1[i])
                        {
                            a = arrNum4[i];
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < 10; i++)
                    {
                        if (number[0] == arr2[i])
                        {
                            a = arrNum1[i];
                        }
                        if (number[1] == arr1[i])
                        {
                            b = arrNum1[i];
                        }

                    }
                }
                result = $"{a}{b}";
            }
            else
            {
                for (int i = 0; i < 10; i++)
                {
                    if (number[0] == arr1[i])
                    {
                        a = arrNum1[i];
                    }
                    else if (number[0] == arr3[i])
                    {
                        a = arrNum5[i];
                    }
                    else if (number[0] == arr2[i])
                    {
                        a = arrNum4[i];
                    }
                }
                result = $"{a}";
            }


            Console.WriteLine(result);

        }
    }
}
