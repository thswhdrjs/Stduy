using UnityEngine;

public class Backjun10813 : MonoBehaviour
{
    int[][] data = new int[4][]
    {
        new int[] { 1, 2 },
        new int[] { 3, 4 },
        new int[] { 1, 4 },
        new int[] { 2, 2 }
    };

    private void Start()
    {
        Algorithm(5, data);
    }

    private void Algorithm(int n, int[][] data)
    {
        int[] basket = new int[n];

        for (int i = 0; i < basket.Length; i++)
            basket[i] = i + 1;

        for (int i = 0; i < data.Length; i++)
        {
            int temp = basket[data[i][0] - 1];
            basket[data[i][0] - 1] = basket[data[i][1] - 1];
            basket[data[i][1] - 1] = temp;
        }

        string output = basket[0].ToString();

        for (int i = 1; i < basket.Length; i++)
            output += " " + basket[i];

        Debug.Log(output);
    }
}
