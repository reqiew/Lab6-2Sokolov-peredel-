

namespace ClassLibrary1
{
    public class Class1
    {
        public static double[] abs(double[,] matrix)
        {
            double[] maxElements = new double[6];
            double[] mas = new double[6];
            for (int i = 0; i < 6; i++)
            {
                double max = matrix[i, 0];
                for (int j = 1; j < 4; j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                    }
                }
                maxElements[i] = max;
            }

            return maxElements;

        }



    }
}
