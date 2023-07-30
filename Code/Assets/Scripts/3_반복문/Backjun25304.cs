using UnityEngine;

public class Backjun25304 : MonoBehaviour
{
    int[][] a = new int[4][]
    {
        new int[]{ 20000, 5 },
        new int[]{ 30000, 2 },
        new int[]{ 10000, 6 },
        new int[]{ 5000, 8 }
    };

    private void Start()
    {
        Algorithm(260000, a);
        Algorithm(250000, a);
    }

    private void Algorithm(int n, int[][] data)
    {
        int sum = 0;
        
        for(int i = 0; i < data.Length; i++)
            sum += data[i][0] * data[i][1];

        Debug.Log(n == sum ? "Yes" : "No");
    }
}
