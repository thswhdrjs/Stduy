using UnityEngine;

public class Backjun1978 : MonoBehaviour
{
    int[] data = new int[4] { 1, 3, 5, 7 };

    private void Start()
    {
        Algorithm(data);
    }

    private void Algorithm(int[] data)
    {
        int count = 0;

        for(int i = 0; i < data.Length; i++)
        {
            if (data[i] == 1)
                continue;
            else
            {
                for (int j = 2; j * j < data[i]; j++)
                {
                    if (data[i] % i == 0)
                        continue;
                }
            }

            count++;
        }

        Debug.Log(count);
    }
}
