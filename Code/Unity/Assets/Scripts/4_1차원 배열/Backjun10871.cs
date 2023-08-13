using UnityEngine;

public class Backjun10871 : MonoBehaviour
{
    int[] data = new int[10] { 1, 10, 4, 9, 2, 3, 8, 5, 7, 6 };

    private void Start()
    {
        Algorithm(data, 5);
    }

    private void Algorithm(int[] data, int findNum)
    {
        int[] arr = new int[data.Length];
        int index = 0;

        for(int i = 0; i < data.Length; i++)
        {
            if (data[i] < findNum)
                arr[index++] = data[i];
        }

        string output = arr[0].ToString();

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] == 0)
                break;

            output += " " + arr[i];
        }

        Debug.Log(output);
    }
}
