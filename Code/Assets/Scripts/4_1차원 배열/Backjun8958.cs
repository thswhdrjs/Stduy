using UnityEngine;

public class Backjun8958 : MonoBehaviour
{
    string[] data = new string[5]
    {
        "OOXXOXXOOO", "OOXXOOXXOO", "OXOXOXOXOXOXOX", "OOOOOOOOOO", "OOOOXOOOOXOOOOX"
    };

    private void Start()
    {
        Algorithm(data);
    }

    private void Algorithm(string[] data)
    {
        int count = 0, total = 0;

        for (int i = 0; i < data.Length; i++)
        {
            total = 0;
            count = 0;

            for (int j = 0; j < data[i].Length; j++)
            {
                if (data[i][j] == 'O')
                {
                    count++;
                    total += count;
                }
                else
                    count = 0;
            }

            Debug.Log(total);
        }
    }
}
