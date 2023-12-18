public class Solution
{
    public void SetZeroes(int[][] matrix)
    {
        List<int> yRow = new List<int>();

        for (int row = 0; row < matrix.Length; row++)
        {
            bool hasZero = false;
            for (int column = 0; column < matrix[0].Length; column++)
            {
                if (matrix[row][column] == 0)
                {
                    hasZero = true;
                    yRow.Add(column);
                }
            }

            if (hasZero)
            {
                for (int column = 0; column < matrix[0].Length; column++)
                {
                    matrix[row][column] = 0;
                }
            }
        }

        foreach (int column in yRow)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row][column] = 0;
            }
        }


    }
}