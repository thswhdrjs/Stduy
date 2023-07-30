using UnityEngine;

public class Backjun1003 : MonoBehaviour
{
    private void Start()
    {
        //DP_Fibonacci
        Debug.Log(DP_Fibonacci(0));
        Debug.Log(DP_Fibonacci(1));
        Debug.Log(DP_Fibonacci(3));

        Debug.Log(DP_Fibonacci(6));
        Debug.Log(DP_Fibonacci(22));

        //Algorithm
        Algorithm(0);
        Algorithm(1);
        Algorithm(3);

        Algorithm(6);
        Algorithm(22);
    }

    private void Algorithm(int n)
    {
        int[,] arr = new int[100, 2];
        arr[0, 0] = 1;
        arr[1, 1] = 1;

        for (int i = 2; i <= n; i++)
        {
            arr[i, 0] = arr[i - 1, 0] + arr[i - 2, 0];
            arr[i, 1] = arr[i - 1, 1] + arr[i - 2, 1];
        }

        Debug.LogFormat("{0} {1}", arr[n, 0], arr[n, 1]);
    }

    private int? DP_Fibonacci(int n)
    {
        int?[] arr = new int?[100];
        arr[0] = 0;
        arr[1] = 1;

        if (arr[n] == null)
            arr[n] = DP_Fibonacci(n - 1) + DP_Fibonacci(n - 2);

        return arr[n];
    }
}
