using UnityEngine;

public class Backjun1546 : MonoBehaviour
{
    int[] data = new int[3] { 40, 80, 60 };
    int[] data2 = new int[3] { 10, 20, 30 };
    int[] data3 = new int[4] { 1, 100, 100, 100 };
    int[] data4 = new int[5] { 1, 2, 4, 8, 16 };
    int[] data5 = new int[2] { 3, 10 };
    int[] data6 = new int[4] { 10, 20, 0, 100 };
    int[] data7 = new int[1] { 50 };
    int[] data8 = new int[9] { 10, 20, 30, 40, 50, 60, 70, 80, 90 };

    private void Start()
    {
        Algorithm(data);
        Algorithm(data2);
        Algorithm(data3);
        Algorithm(data4);
        Algorithm(data5);
        Algorithm(data6);
        Algorithm(data7);
        Algorithm(data8);
    }

    private void Algorithm(int[] data)
    {
        float[] changesScores = new float[data.Length];
        float sum = 0;

        int max = 0;

        for (int i = 0; i < data.Length; i++)
        {
            if (max < data[i])
                max = data[i];
        }

        for (int i = 0; i < data.Length; i++)
            changesScores[i] = (float)data[i] / (float)max * 100f;

        for (int i = 0; i < changesScores.Length; i++)
            sum += changesScores[i];

        Debug.Log(sum / changesScores.Length);
    }
}
