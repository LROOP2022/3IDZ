using Matrixx;
namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix= new Matrix(3,3);
            Matrix.PrintMatrix(matrix);
            float []m=Matrix.GetSrArif(matrix);
            foreach (int i in m)
            {
                Console.Write(" "+i);
            }
            Console.WriteLine();
            Console.WriteLine();
            Matrix.PrintResultMatrix(matrix);
        }
    }
}
