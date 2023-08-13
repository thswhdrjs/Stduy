using UnityEngine;

public class Backjun3052 : MonoBehaviour
{
    int[] data = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    int[] data2 = new int[10] { 42, 84, 252, 420, 840, 126, 42, 84, 420, 126 };
    int[] data3 = new int[10] { 39, 40, 41, 42, 43, 44, 82, 83, 84, 85 };

    private void Start()
    {
        Algorithm(data);
        Algorithm(data2);
        Algorithm(data3);
    }

    private void Algorithm(int[] data)
    {
        int[] num = new int[42];
        int sum = 0;

        for (int i = 0; i < data.Length; i++)
        {
            if (num[data[i] % 42] == 0)
                num[data[i] % 42]++;
        }

        for (int i = 0; i < num.Length; i++)
            sum += num[i];

        Debug.Log(sum);
    }
}
