using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            #region OneDimensionArray
            int[] arr;
            arr = new int[10];
            arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = (i * i) + 1;
            }
            //arr = null;
            
            Random rnd = new Random();
            
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(100);
            }
            
            int[] arr2;
            arr2 = arr;
            arr[0] = 100;
            int[] arr3 = new int[10];
            
            Array.Copy(arr, arr3, arr.Length);
            ShowOneDimensionArray(arr);
            Console.WriteLine("---------");
            ShowOneDimensionArray(arr2);
            #endregion
            #region TwoDimensionArray
            int[,] twoDimensionArr;
            int[,] twoDimensionArr2 = new int[3, 3];
            int[,] twoDimensionArr3 = new int[,] { { 0, 1, 2 }, { 1, 2, 3 },{ 2, 3, 4 },{ 3, 4, 5 } };

            ShowTwoDimensionArray = ShowTwoDimensionArray(twoDimensionArr3);

            for (int i = 0; i < arr3.GetLength(0); i++)
            {
                for (int j = 0; j < arr3.GetLength(0); j++)
                {
                    arr[i, j] = (i + 1) * (j +1);

                }
                ShowTwoDimensionArray(arr[i]);

            }




            #endregion
            #region Jagged Arrays
            int[][] jaggedArr;
            int[][] jaggedArr2 = new int[5][];
            int[][] jaggedArr3 = new int[5][];
            jaggedArr3[0] = new int[] { 1, 2, 3 };
            jaggedArr3[1] = new int[] { 1, 2, 3, 4, 5, 6 };
            jaggedArr3[2] = new int[] { 1, 2, 3, 4 };
            jaggedArr3[3] = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            jaggedArr3[4] = new int[] { 1 };

            for (int i = 0; i < jaggedArr3.Length; i++)
            {
                for (int j = 0; j < jaggedArr3[i].Length; j++)
                {
                    Console.Write(jaggedArr3[i][j] + " ");

                }
                Console.WriteLine();
            }















            #endregion
        }

        private static void ShowTwoDimensionArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(i+1 +". line" + (j+1) + ". column="+arr[i,j]);
                }
            }
        }

        static void ShowOneDimensionArray(int[] arr)
        {
            if (arr == null)
            {
                Console.WriteLine("Error. Null Array!!");
            }
            else
            {

            }
            
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            //foreach ( int item in arr)
            {

            }
        }
    }
}
