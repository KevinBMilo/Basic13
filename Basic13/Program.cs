using System;
using System.Collections.Generic;
using System.Text;

namespace Basic13
{
    class Program
    {

        static void Main(string[] args)
        {
            int intOne = 1;
            Int32 intTwo = 2;
            String stringThree = "3";
            Program.doStuff(ref intOne, intTwo, ref stringThree);
            Console.WriteLine("{0}, {1}, {2}", intOne, intTwo, stringThree);
            // int[,]TestArray = new int[,]
            // {
            //     {1,2,3,4,5,6,7,8,9},
            //     {11,21,31,41,51,61,71,81,91},
            //     {11,22,33,44,55,66,77,88,99}
            // };
            // System.Console.Write(TestArray.GetUpperBound(0) + "," + TestArray.Length);

            // int a = 1, b = 2;
            // if (++a ==1)
            // Console.WriteLine(a++ + b * 2);
            // else
            // Console.WriteLine(a-- * b);
            // RunByte();
        // Console.WriteLine("Testing");
        // FindMax();
        // PrintOdds();
        // OddArray();
        // GreaterThanY();
        // SquareArrayValues();
        // ElimNegatives();
        // MinMaxAverage();
        // ShiftValues();
        // NumToString();
        // RandomString();
        // RandomNumber();
        // RandomPassword();
        // Generate();
        // RandomTest();
        
        }
        public static void PrintNumbers()
        {
            for (var i = 0; i < 256; i++){
                Console.WriteLine(i);
            }
        }
        public static void PrintOdds()
        {
            for (var i = 0; i < 256; i++){
            if (i % 2 == 1){
                Console.WriteLine(i);
            }
            }
        }
        public static void Sum()
        {
            var sum = 0;
            for (var i = 0; i < 256; i++){
            sum = sum + i;
            Console.WriteLine($"New number: {i} Sum: {sum}");
            }
        }
        public static void LoopArray()
        {
            int[] Array = {1,7,7,6,1,8,1,2};
            int start = 0;
            int end = Array.Length;
            for (int i = start; i < end; i++){
                Console.WriteLine(Array[i]);
            }
        }
        public static void FindMax()
        {
            int[] Array = {1,-4,3,4,-5,23,32,1,0};
            var max = Array[0];
            int start = 0;
            int end = Array.Length;
            Console.WriteLine("Entering the shit");
            for (int i = start; i < end; i++)
            {
                Console.WriteLine(Array[i]);
                if (Array[i] > max)
                {
                max = Array[i];
                }
            }
            Console.WriteLine($"Max value after loop {max}");
        }
        public static void GetAvg()
        {
            int[] Array = {1,3,4,5,23,32,1};
            int start = 0;
            int sum = 0;
            int end = Array.Length;
            for (int i = start; i < end; i++)
            {
                var avg = sum/Array.Length;
                sum += Array[i];
                Console.WriteLine($"{avg}");
                Console.WriteLine($"{sum}");
                avg = sum/Array.Length;
                Console.WriteLine($"Avg value after loop {avg}");
            }
        }
        public static int[] OddArray()
        {
            List<int> tmpList = new List <int>();
            for (int i = 0; i < 256; i++){
            if (i % 2 == 1){
                tmpList.Add(i);
            }
            }
            var newArray = tmpList.ToArray();
            Console.WriteLine(newArray);
            return newArray;
        }
        public static void GreaterThanY()
        {
            int[] Array = {1,2,3,4,5,6,7,8};
            int start = 0;
            int end = Array.Length;
            int y = 1;
            int hw = 0;
            for (int i = start; i < end; i++){
                if (Array[i] > y){
                    hw ++;
                }
            }
            Console.WriteLine(hw);
        }
        public static void SquareArrayValues()
        {
            int[] Array = {1,2,3,4};
            int start = 0;
            int end = Array.Length;
            for (int i = start; i < end; i++){
                Array[i] *= Array[i];
                Console.WriteLine(Array[i]);
            }
        }
        public static void ElimNegatives()
        {
           int[] Array = {-1, 1, -33, 1, -4, 1};
           int start = 0;
           int end = Array.Length;
           for (int i = start; i < end; i++){
               if (Array[i] < 0){
                   Array[i]= 0;
               }
            Console.WriteLine(Array[i]);
           }
        }
        public static void MinMaxAverage()
        {
            int[] Array = {1,9,8,6,6,3};
            int start = 0;
            int end = Array.Length;
            var max = Array[0];
            var min = Array[0];
            var sum = 0;
            for (int i = start; i < end; i ++){
                sum += Array[i];
                if (Array[i] > max){
                    max = Array[i];
                }
                if (Array[i] < min){
                    min = Array[i];
                }
            }
            var avg = sum/Array.Length;
            Console.WriteLine($"The max is {max}.");
            Console.WriteLine($"The min is {min}.");
            Console.WriteLine($"The average is {avg}.");
        }
        public static void ShiftValues()
        {
            int[] Array = {1,6,0,5};
            List<int> tmpList = new List <int>();
            int start = 1;
            int end = Array.Length;
            for (int i = start; i < end; i ++){
                tmpList.Add(Array[i]);
            }
            tmpList.Add(0);
        }
        public static object[] NumToString()
        {
            int[] Array = {-1, -2, -6};
            List<string> tmpList = new List <string>();
            int start = 0;
            int end = Array.Length;
            for (int i = start; i < end; i ++){
                if(Array[i] < 0){
                    tmpList.Add("Dojo");
                }
                else{
                    string val = Convert.ToString(Array[i]);
                    tmpList.Add(val);
                }
            }
            var newArray = tmpList.ToArray();
            return newArray;
        }
        public static void Generate()
        {
            Random rand = new Random();
            char[] newArray = new char[]{'A','B', 'C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};
            // char[] newArray2 = new char[]{'a','b','c','d','e','f','g','h','i','j','k','l','m','n','','','','','','','','','','',''};
            // any passArray = new any[];
            // newArray.Length = 14;
            // for(int i = 0; i < 7; i++)
            // {
            //     Console.WriteLine((rand.Next(1,9)));
            //     Console.WriteLine(newArray[rand.Next(0,26)]);
            //     Console.WriteLine(newArray2[rand.Next(0,26)]);
            // }
            // string newPass = Convert.ToString(passArray);
            // return newPass;
        }
        public static void RandomTest()
        {
            Random rand = new Random();
            for(int val = 0; val < 10; val++)
            {
                Console.WriteLine(rand.Next(2,9));
            }
        }
        public static void RunByte()
        {
            int intValue = 250;
            byte byteValue = (byte)intValue;
            Console.WriteLine(byteValue);
        }
        private static void doStuff(ref int intOne, Int32 intTwo, ref String stringThree)
        {
            intOne = 100;
            intTwo = 200;
            stringThree = "300";
        }
    }
}
