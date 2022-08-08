int solution(int[][] matrix)
        {
            int sonuc = 0;

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        for (int k = i; k < matrix.Length; k++)
                            matrix[k][j] = 0;
                    }  
                }
            }

            for (int m = 0; m < matrix.Length; m++)
            {
                for (int n = 0; n < matrix[m].Length; n++)
                {
                    if (matrix[m][n] != 0)
                        sonuc += matrix[m][n]; 
                }
            }
            return sonuc;
        }
