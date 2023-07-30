using UnityEngine;

public class Backjun10810 : MonoBehaviour
{
    int[][] data = new int[4][]
    { 
        new int[] { 1, 2, 3 },
        new int[] { 3, 4, 4 },
        new int[] { 1, 4, 1 },
        new int[] { 2, 2, 2 }
    };

    private void Start()
    {
        Algorithm(5, data);
    }

    private void Algorithm(int n, int[][] data)
    {
        int[] basket = new int[n + 1];

        for(int i = 0; i < data.Length; i++)
        {
            for (int j = data[i][0]; j <= data[i][1]; j++)
                basket[j] = data[i][2]; 
        }

        string output = basket[1].ToString();

        for(int i = 2; i < basket.Length; i++)
            output += " " + basket[i];

        Debug.Log(output);
    }
}
