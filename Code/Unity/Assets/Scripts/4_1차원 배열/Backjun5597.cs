using UnityEngine;

public class Backjun5597 : MonoBehaviour
{
    int[] data = new int[28]{ 3, 1, 4, 5, 7, 9, 6, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30};
    int[] data2 = new int[28] { 9, 30, 6, 12, 10, 20, 21, 11, 7, 5, 28, 4, 18, 29, 17, 19, 27, 13, 16, 26, 14, 23, 22, 15, 3, 1, 24, 25};

    private void Start()
    {
        Algorithm(data);
        Algorithm(data2);
    }

    private void Algorithm(int[] data)
    {
        int[] arr = new int[31];
        
        for(int i = 0; i < data.Length; i++)
            arr[data[i]] = 1;

        int[] result = new int[2];
        int index = 0;

        for(int i = 1; i < arr.Length; i++)
        {
            if (arr[i] == 0)
                result[index++] = i;
        }

        Debug.Log(result[0] + " " + result[1]);
    }
}
