using UnityEngine;

public class Backjun11021 : MonoBehaviour
{
    int[][] data = new int[5][]
    {
        new int[]{ 1, 1 },
        new int[]{ 2, 3 },
        new int[]{ 3, 4 },
        new int[]{ 9, 8 },
        new int[]{ 2, 2 }
    };

    private void Start()
    {
        Algorithm(data);
    }

    private void Algorithm(int[][] data)
    {
        for (int i = 0; i < data.Length; i++)
            Debug.Log("Case #1: " + (data[i][0] + data[i][1]));
    }
}
