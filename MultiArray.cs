using System;

namespace _02.MultiDimArrayExamples
{
    class MultiArray
    {
        static void Main(string[] args)
        {
            int[,] numbers = new int[5,10];      //5 rows and 10 columns-twoDimensionalArray/Matrix, table, excel table
            numbers[3, 2] = 100;                 //i want on third row , tow with index  3 , tio write and column with index 2 to //
            //write the  numer  100 , we initialize the 3rd row, sec col the numenr 100 ;
            Console.WriteLine(numbers[3, 2]); //row indexing 0, 1 , 2 , 3..., column indexing: 0, 1 , 2 , 3
            //[,] --this means i want two diemnsons i want rows, i want columns;

            //string[,] stringArray = new string[5, 5];  //we declare a string array with five rows, and five columns;
            //string[,] text = new striong[5, 5];

            string[,,] text3D = new string[5, 5, 5]; //three dimArray, index for rows, for columns, for Depth -> [, ,]
            //we have a cube with dimension : 5 :5:-five rows, five columns, five debth
            text3D[1, 2, 3] = "Pesho";//we initialize on first row,second columns,third depth the cell values to be"Pesho"
            Console.WriteLine(text3D[1,2,2]);

            string[,] texts = new string[5, 5]; //declarinf twoDimensional Array
            texts[0, 0] = "Pesho";
            texts[0, 1] = "Gosho";
            texts[0, 2] = "Ivan";

        }
    }
}
