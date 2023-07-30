using UnityEngine;

public class Backjun15552 : MonoBehaviour
{
    int[][] data = new int[5][]
    {
        new int[]{ 1, 1 },
        new int[]{ 12, 34 },
        new int[]{ 5, 500 },
        new int[]{ 40, 60 },
        new int[]{ 1000, 1000 }
    };

    private void Start()
    {
        Algorithm(data);
    }

    private void Algorithm(int[][] data)
    {
        for (int i = 0; i < data.Length; i++)
            Debug.Log(data[i][0] + data[i][1]);
    }
}
