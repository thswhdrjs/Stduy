using UnityEngine;

public class Backjun1004 : MonoBehaviour
{
    int[][] data = new int[7][]
    {
        new int[]{ 1, 1, 8 },
        new int[]{ -3,-1,1 },
        new int[]{ 2, 2, 2 },
        new int[]{ 5, 5, 1 },
        new int[]{ -4, 5, 1 },
        new int[]{ 12, 1, 1 },
        new int[]{ 12, 1, 2 },
    };
    int[][] data2 = new int[1][]
    {
        new int[]{ 0, 0, 2 }
    };

    int[][] data3 = new int[3][]
    {
        new int[]{ 0, 0, 2 },
        new int[]{ -6, 1, 2 },
        new int[]{ 6, 2, 2 }
    };
    int[][] data4 = new int[8][]
    {
        new int[]{ -3, -1, 1 },
        new int[]{ 2, 2, 3 },
        new int[]{ 2, 3, 1 },
        new int[]{ 0, 1, 7 },
        new int[]{ -4, 5, 1 },
        new int[]{ 12, 1, 1 },
        new int[]{ 12, 1, 2 },
        new int[]{ 12, 1, 3 }
    };
    int[][] data5 = new int[12][]
    {
        new int[] { -107, 175, 135 },
        new int[] { -38, -115, 42 },
        new int[] { 140, 23, 70 },
        new int[] { 148, -2, 39 },
        new int[] { -198, -49, 89 },
        new int[] { 172, -151, 39 },
        new int[] { -179, -52, 43 },
        new int[] { 148, 42, 150 },
        new int[] { 176, 0, 10 },
        new int[] { 153, 68, 120 },
        new int[] { -56, 109, 16 },
        new int[] { -187, -174, 8 }
    };

    private void Start()
    {
        Algorithm(-5, 1, 12, 1, data);
        Algorithm(-5, 1, 12, 1, data2);

        Algorithm(-5, 1, 5, 1, data3);
        Algorithm(2, 3, 13, 2, data4);
        Algorithm(102, 16, 19, -108, data5);
    }

    private void Algorithm(int x1, int y1, int x2, int y2, int[][] c)
    {
        int count = 0;
        bool in1 = false, in2 = false;

        for (int i = 0; i < c.Length; i++)
        {
            in1 = Mathf.Pow(c[i][0] - x1, 2) + Mathf.Pow(c[i][1] - y1, 2) > Mathf.Pow(c[i][2], 2) ? true : false;
            in2 = Mathf.Pow(c[i][0] - x2, 2) + Mathf.Pow(c[i][1] - y2, 2) > Mathf.Pow(c[i][2], 2) ? true : false;

            if (in1 != in2)
                count++;
        }

        Debug.Log(count);
    }
}
