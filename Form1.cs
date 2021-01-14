using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_encryption_grid_WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        //------------------------------------------------------------------------------------------------------------------------------------------
        //ABC grid 4x5


        private void AlphabetGridOK(ref int[,] grid5By4, out string gridatringABC)
        {

            char[] AZ = Enumerable.Range('a', 'z' - 'a' + 1).Select(i => (Char)i).ToArray();

            char[] AZinput = textBoxAlphabet.Text.ToCharArray();

            if (!(AZinput.Length == 0))
            {
                AZ = AZinput;

            }

            int lengthAZ = AZ.Length;

            int a = 0;

            //Assigning Values to matrix[10,10] array  
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (a > lengthAZ - 1)
                    {
                        a = 0;
                    }

                    gridatringABC = string.Format(" {0,0} ", AZ[a]);

                    int length = gridatringABC.Length;

                    matrixStrABC[i, j] = gridatringABC;

                    a++;
                }
            }


            string gridstringClear = "";

            for (int i = 0; i <= matrixStrABC.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= matrixStrABC.GetUpperBound(1); j++)
                {

                    gridstringClear += string.Format("{0,0}", matrixStrABC[i, j]);

                }

                gridstringClear += "\n";
            }

            gridatringABC = gridstringClear;

        }


        private string[,] matrixStrABC = new String[4, 5];

        private int[,] matrixIntABC4by5 = new int[4, 5];

        private void buttonAlphaB_Click(object sender, EventArgs e)
        {
            string gridatringABC = "";
            AlphabetGridOK(ref matrixIntABC4by5, out gridatringABC);
            lblShowResult.Text = gridatringABC;
        }


        //ABC grid 4x5
        //------------------------------------------------------------------------------------------------------------------------------------------








        //int[,] matrix = new int[10, 10];

        ////Assigning Values to matrix[10,10] array  
        //for (int i = 0; i < 10; i++)
        //{
        //    for (int j = 0; j < 10; j++)
        //    {
        //        matrix[i, j] = i * 10 + j + 1;


        //    }
        //}






        //------------------------------------------------------------------------------------------------------------------------------------------
        //Recursion  Numbers grid 5x5


        private void Recursion(ref int[,] grid5By5, out string gridatringABC)
        {
            string gridstringClear = "";
            gridatringABC = "";

            int k1 = 0, k2 = 0;
            // Flag variable for handling
            // bottum up diagonal traversing
            bool flag = true;
            int ii = 0;
            int jj = 0;

            int[,] mtrx55 = {
                { 10, 11, 12, 13, 14 },
                { 15, 16, 17, 18, 19 },
                { 20, 21, 22, 23, 24 },
                { 25, 26, 27, 28, 29 },
                { 30, 31, 32, 33, 34 }
            };
            // Function call for  
            // traversing matrix
            traverseMatrixDiagonally(mtrx55, 0, 0, 5, 5);



            bool traverseMatrixDiagonally(int[,] m, int i, int j, int row, int col)
            {

                // Base Condition
                if (i >= row || j >= col)
                {
                    // Condition when to traverse
                    // Bottom Diagonal of the matrix
                    if (flag)
                    {
                        int a = k1;
                        k1 = k2;
                        k2 = a;
                        flag = !flag;
                        k1++;
                    }
                    else
                    {
                        int a = k1;
                        k1 = k2;
                        k2 = a;
                        flag = !flag;
                    }

                    gridstringClear += "\n";
                    //Console.WriteLine();
                    return false;
                }

                // Print matrix cell value
                //Console.Write(m[i, j] + " ");


                gridstringClear += (m[i, j] + " ");


                if (jj > 4)
                {
                    jj = 0;
                }
                matrixY[i, j] = m[ii, jj];
                jj++;
                if (jj > 4)
                {
                    ii++;
                }

                // Recursive function to traverse
                // The matrix diagonally
                if (traverseMatrixDiagonally(m, i + 1, j + 1, row, col))
                {
                    return true;
                }

                // Recursive function 
                // to change diagonal
                if (traverseMatrixDiagonally(m, k1, k2, row, col))
                {
                    return true;
                }

                return true;
            }



            for (int i = 0; i <= matrixY.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= matrixY.GetUpperBound(1); j++)
                {

                    gridstringClear += string.Format(" {0,0} ", matrixY[i, j]);

                }

                gridstringClear += "\n";
            }

            gridatringABC = gridstringClear;


        }



        int[,] matrixY = new int[5, 5];


        private int[,] matrixIntABC5by5 = new int[5, 5];
        private void button1_Click(object sender, EventArgs e)
        {
            string gridatringABC = "";
            Recursion(ref matrixIntABC5by5, out gridatringABC);
            lblShowResult.Text = gridatringABC;

        }


        //Recursion  Numbers grid 5x5
        //------------------------------------------------------------------------------------------------------------------------------------------










        //------------------------------------------------------------------------------------------------------------------------------------------
        //RecursionInput  ABC grid 5x5


        private void RecursionInput(ref int[,] grid5By4, out string gridatringABC)
        {

            //INPUT
            char[] AZ = Enumerable.Range('a', 'z' - 'a' + 1).Select(i => (Char)i).ToArray();
            char[] AZinput = textBoxAlphabet.Text.ToCharArray();
            if (!(AZinput.Length == 0))
            {
                AZ = AZinput;
            }
            int lengthAZ = AZ.Length;
            int a = 0;
            //Assigning Values to matrix[10,10] array  
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (a > lengthAZ - 1)
                    {
                        a = 0;
                    }
                    gridatringABC = string.Format(" {0,0} ", AZ[a]);
                    matrixStrABC55[i, j] = gridatringABC;
                    a++;
                }
            }
            //END OF INPUT


            int k1 = 0, k2 = 0;
            // Flag variable for handling
            // bottum up diagonal traversing
            bool flag = true;
            int ii = 0;
            int jj = 0;


            string gridstringClear = "";
            gridatringABC = "";

            // Function call for  
            // traversing matrix
            string[,] matrixAB = new string[5, 5];
            traverseMatrixDiagonally(matrixAB, 0, 0, 5, 5);


            // Recursion traversing matrix
            bool traverseMatrixDiagonally(string[,] m, int i, int j, int row, int col)
            {
                // Base Condition
                if (i >= row || j >= col)
                {
                    // Condition when to traverse
                    // Bottom Diagonal of the matrix
                    if (flag)
                    {
                        int a = k1;
                        k1 = k2;
                        k2 = a;
                        flag = !flag;
                        k1++;
                    }
                    else
                    {
                        int a = k1;
                        k1 = k2;
                        k2 = a;
                        flag = !flag;
                    }

                    gridstringClear += "\n";
                    //Console.WriteLine();
                    return false;
                }
                // Print matrix cell value
                //Console.Write(m[i, j] + " ");
                gridstringClear += (matrixStrABC55[i, j] + " ");

                if (jj > 4)
                {
                    jj = 0;
                }
                matrixABC[i, j] = matrixStrABC55[ii, jj];
                jj++;
                if (jj > 4)
                {
                    ii++;
                }

                // Recursive function to traverse
                // The matrix diagonally
                if (traverseMatrixDiagonally(m, i + 1, j + 1, row, col))
                {
                    return true;
                }

                // Recursive function 
                // to change diagonal
                if (traverseMatrixDiagonally(m, k1, k2, row, col))
                {
                    return true;
                }
                return true;
            }


            // OUTPUT

            for (int i = 0; i <= matrixABC.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= matrixABC.GetUpperBound(1); j++)
                {

                    gridstringClear += string.Format(" {0,0} ", matrixABC[i, j]);
                }
                gridstringClear += "\n";
            }
            gridatringABC = gridstringClear;
        }




        private string[,] matrixStrABC55 = new String[5, 5]; // The input ABC or your input

        private int[,] matrixIntABC55 = new int[5, 5];  // ref typr for method

        string[,] matrixABC = new string[5, 5];  // out matrix

        private void buttonAlphaD_Click(object sender, EventArgs e)
        {
            string gridatringABC = "";
            RecursionInput(ref matrixIntABC55, out gridatringABC);
            lblShowResult.Text = gridatringABC;
        }










        //------------------------------------------------------------------------------------------------------------------------------------------
        //RecursionInput  ABC grid 5x5


        private void RecursionInput10by10(ref int[,] grid5By4, out string gridatringABC)
        {

            //INPUT
            char[] AZ = Enumerable.Range('a', 'z' - 'a' + 1).Select(i => (Char)i).ToArray();
            char[] AZinput = textBoxAlphabet.Text.ToCharArray();
            if (!(AZinput.Length == 0))
            {
                AZ = AZinput;
            }
            int lengthAZ = AZ.Length;
            int a = 0;
            //Assigning Values to matrix[10,10] array  
            for (int i = 0; i < matrixStrABC55z.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < matrixStrABC55z.GetUpperBound(0) + 1; j++)
                {
                    if (a > lengthAZ - 1)
                    {
                        a = 0;
                    }
                    gridatringABC = string.Format(" {0,0} ", AZ[a]);
                    matrixStrABC55z[i, j] = gridatringABC;
                    a++;
                }
            }
            //END OF INPUT


            int k1 = 0, k2 = 0;
            // Flag variable for handling
            // bottum up diagonal traversing
            bool flag = true;
            int ii = 0;
            int jj = 0;


            string gridstringClear = "";
            gridatringABC = "";

            // Function call for  
            // traversing matrix
            string[,] matrixABz = new string[10, 10];
            traverseMatrixDiagonally(matrixABz, 0, 0, 10, 10);


            // Recursion traversing matrix
            bool traverseMatrixDiagonally(string[,] m, int i, int j, int row, int col)
            {
                // Base Condition
                if (i >= row || j >= col)
                {
                    // Condition when to traverse
                    // Bottom Diagonal of the matrix
                    if (flag)
                    {
                        int a = k1;
                        k1 = k2;
                        k2 = a;
                        flag = !flag;
                        k1++;
                    }
                    else
                    {
                        int a = k1;
                        k1 = k2;
                        k2 = a;
                        flag = !flag;
                    }

                    gridstringClear += "\n";
                    //Console.WriteLine();
                    return false;
                }
                // Print matrix cell value
                //Console.Write(m[i, j] + " ");
                gridstringClear += (matrixStrABC55z[i, j] + " ");

                if (jj > 9)
                {
                    jj = 0;
                }
                matrixABCz[i, j] = matrixStrABC55z[ii, jj];
                jj++;
                if (jj > 9)
                {
                    ii++;
                }

                // Recursive function to traverse
                // The matrix diagonally
                if (traverseMatrixDiagonally(m, i + 1, j + 1, row, col))
                {
                    return true;
                }

                // Recursive function 
                // to change diagonal
                if (traverseMatrixDiagonally(m, k1, k2, row, col))
                {
                    return true;
                }
                return true;
            }


            // OUTPUT

            for (int i = 0; i <= matrixABCz.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= matrixABCz.GetUpperBound(1); j++)
                {

                    gridstringClear += string.Format(" {0,0} ", matrixABCz[i, j]);
                }
                gridstringClear += "\n";
            }
            gridatringABC = gridstringClear;
        }




        private string[,] matrixStrABC55z = new String[10, 10]; // The input ABC or your input

        private int[,] matrixIntABC55z = new int[10, 10];  // ref typr for method

        string[,] matrixABCz = new string[10, 10];  // out matrix







        private void buttonAlphaE10x10_Click(object sender, EventArgs e)
        {
            string gridatringABC = "";
            RecursionInput10by10(ref matrixIntABC55z, out gridatringABC);
            lblShowResult.Text = gridatringABC;
        }


        //RecursionInput  ABC grid 5x5
        //------------------------------------------------------------------------------------------------------------------------------------------














        //------------------------------------------------------------------------------------------------------------------------------------------
        //AlphabetGrid





        private void AlphabetGrid(ref int[,] grid5By4, out string gridatringABC)
        {


            //INPUT
            char[] AZ = Enumerable.Range('a', 'z' - 'a' + 1).Select(i => (Char)i).ToArray();
            char[] AZinput = textBoxAlphabet.Text.ToCharArray();
            if (!(AZinput.Length == 0))
            {
                AZ = AZinput;
            }
            int lengthAZ = AZ.Length;
            int a = 0;

            //Assigning Values to matrix[10,10] array  
            for (int i = 0; i <= matrixStrABC55zA.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= matrixStrABC55zA.GetUpperBound(1); j++)
                {
                    if (a > lengthAZ - 1)
                    {
                        a = 0;
                    }
                    gridatringABC = string.Format(" {0,0} ", AZ[a]);
                    matrixStrABC55zA[i, j] = gridatringABC;
                    a++;
                }
            }
            //END OF INPUT


            int m = 4; //matrix rows and columns
            int n = 5;

            int ii = 0;
            int jj = 0;
            int k = 0;

            int iia = 0;
            int jja = 0;

            gridatringABC = "";

            for (k = 0; k <= m - 1; k++)
            {

                ii = k;
                jj = 0;

                while (ii >= 0)
                {
                    gridatringABC += string.Format(" {0,0} ", matrixStrABC55zA[ii, jj]);


                    if (jja > 4)
                    {
                        jja = 0;
                    }
                    matrixStrABC3[ii, jj] = matrixStrABC55zA[iia, jja];
                    jja++;
                    if (jja > 4)
                    {
                        iia++;
                    }


                    ii = ii - 1;
                    jj = jj + 1;

                }
            }

            for (k = 1; k <= n - 1; k++)
            {

                ii = m - 1;
                jj = k;

                while (jj <= n - 1)
                {
                    gridatringABC += string.Format(" {0,0} ", matrixStrABC55z[ii, jj]);


                    if (jja > 4)
                    {
                        jja = 0;
                    }
                    matrixStrABC3[ii, jj] = matrixStrABC55zA[iia, jja];
                    jja++;
                    if (jja > 4)
                    {
                        iia++;
                    }


                    ii = ii - 1;
                    jj = jj + 1;

                }
            }



            string[] stringArray = new string[10];
            string[] stringArray1 = new string[10];

            //string[] splitWords = message.Split(new Char[] { ' ' },    
            // How to convert string to string[]? [closed] https://stackoverflow.com/questions/11081549/how-to-convert-string-to-string


            stringArray = gridatringABC.ToCharArray().Select(c => c.ToString()).ToArray();


            // Remove blank values from array using C# https://stackoverflow.com/questions/8814811/remove-blank-values-from-array-using-c-sharp/8814849#8814849
            //stringArray = stringArray.Where(x => !string.IsNullOrEmpty(x)).ToArray();



            var temp = new List<string>();
            foreach (var s in stringArray)
            {
                if (s != " ")
                    temp.Add(s);
            }
            stringArray = temp.ToArray();



            //C# convert 1D array to 2D https://stackoverflow.com/questions/28113015/c-sharp-convert-1d-array-to-2d
            static T[,] Make2DArray<T>(T[] input, int height, int width)
            {
                T[,] output = new T[height, width];
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        output[i, j] = input[i * width + j];
                    }
                }
                return output;
            }

            //int[] a;  //or any other array.
            //var twoDArray = Make2DArray(stringArray, 4, 5);







            string gridstringClear = "";

            for (int i = 0; i <= matrixStrABC3.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= matrixStrABC3.GetUpperBound(1); j++)
                {

                    gridstringClear += string.Format(" {0,0} ", matrixStrABC3[i, j]);      /* twoDArray[i, j]);*/


                }

                gridstringClear += "\n";
            }

            gridatringABC = gridstringClear;

        }

        private string[,] matrixStrABC55zA = new String[4, 5]; // The input ABC or your input

        private string[,] matrixStrABC3 = new String[4, 5];

        private int[,] matrixIntABC45 = new int[4, 5];


        private void buttonAlphaBB_Click(object sender, EventArgs e)
        {
            string gridatringABC = "";
            AlphabetGrid(ref matrixIntABC45, out gridatringABC);
            lblShowResult.Text = gridatringABC;

        }
    }





}
