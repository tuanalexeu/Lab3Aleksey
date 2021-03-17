using System;

namespace Lab3Aleksey {
    class Program {
        static void Main(string[] args) {
            //
            // // Метод Гаусса
            // GausMethod gausMethod = new GausMethod(4,4);
            // double[][] matrix1 = new double[4][];
            //
            // matrix1[0] = new double[] {1, 2, 2, 1, 0};
            // matrix1[1] = new double[] {2, 3, 3, 2, 0};
            // matrix1[2] = new double[] {3, 5, 4, 2, 1};
            // matrix1[3] = new double[] {4, 7, 6, 2, 2};
            //
            // gausMethod.Matrix = matrix1;
            // printArray(gausMethod.SolveMatrix());
            //
            // // Метод прогонки
            // double[][] matrix2 = new double[4][];
            // matrix2[0] = new double[] {4, 1, 0, 0, 5};
            // matrix2[1] = new double[] {1, 3, -2.5, 0, 2};
            // matrix2[2] = new double[] {0, 1.5, -5, 1, 1};
            // matrix2[3] = new double[] {0, 0, 2, 4, 7};
            //
            // TridiagonalMatrixExample tridiagonal = new TridiagonalMatrixExample(matrix2);
            // printArray(tridiagonal.GetSolution());
            
            Console.Write((double) 407/364 + " ");
            Console.Write((double)48/91 + " ");
            Console.Write((double)51/182 + " ");
            Console.Write((double)293/182 + " ");
        }
        
        static void printArray(double[] a) {
            for (int i = 0; i < a.Length; i++) {
                Console.Write(a[i] + " ");
            }
        }
    }
}