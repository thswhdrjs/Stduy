using UnityEngine;

public class Backjun2447 : MonoBehaviour
{
    private void Start()
    {
        Algorithm(27);
    }

    private void Algorithm(int n)
    {
        string output = "";
        string[,] arr = new string[n, n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                arr[i, j] = " ";
            }
        }

        Star(arr, 0, 0, n);

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
                output += arr[i, j];

            output += "\n";
        }

        Debug.Log(output);
    }

    private void Star(string[,] arr, int row, int col, int n)
    {
        if (n == 1)
        {
            arr[row, col] = "*";
            return;
        }

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (!(i == 1 && j == 1))
                    Star(arr, row + (i * n / 3), col + (j * n / 3), n / 3);
            }
        }
    }
}
