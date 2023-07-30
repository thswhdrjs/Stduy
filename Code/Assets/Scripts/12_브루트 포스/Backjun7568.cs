using UnityEngine;

public class Backjun7568 : MonoBehaviour
{
    int[][] data = new int[5][]
    {
        new int[]{55, 185},
        new int[]{58, 183},
        new int[]{88, 186},
        new int[]{60, 175},
        new int[]{46, 155}
    };

    private void Start()
    {
        Algorithm(data);
    }

    private void Algorithm(int[][] physical)
    {
        int[,] ranking = new int[physical.Length, 2];
        int[] order = new int[physical.Length];

        for (int i = 0; i < physical.Length; i++)
        {
            int weightOrder = 0;
            int heightOrder = 0;

            for (int j = 0; j < physical.Length; j++)
            {
                if (i == j)
                    continue;

                for (int k = 0; k < 2; k++)
                {
                    if (physical[i][k] < physical[j][k])
                    {
                        if (k == 0)
                            weightOrder++;
                        else
                            heightOrder++;
                    }
                }
            }

            ranking[i, 0] = ++weightOrder;
            ranking[i, 1] = ++heightOrder;
        }

        for (int i = 0; i < physical.Length; i++)
        {
            int currOrder = 0;

            for (int j = 0; j < physical.Length; j++)
            {
                if (i == j)
                    continue;

                if (ranking[i, 0] > ranking[j, 0] && ranking[i, 1] > ranking[j, 1])
                    currOrder++;
            }

            order[i] = ++currOrder;
        }

        string output = order[0].ToString();

        for (int i = 1; i < physical.Length; i++)
            output+= " " + order[i];

        Debug.Log(output);
    }
}
