using UnityEngine;

public class Backjun2108 : MonoBehaviour
{
    int[] data = new int[5] { 1, 3, 8, -2, 2 };
    int[] data2 = new int[1] { 4000 };
    int[] data3 = new int[5] { -1, -2, -3, -1, -2 };
    int[] data4 = new int[3] { 0, 0, -1 };

    private void Start()
    {
        Algorithm(data);
        Algorithm(data2);
        Algorithm(data3);
        Algorithm(data4);
    }

    private void Algorithm(int[] n)
    {
        int arithmeticMean = 0, medianValue = 0, mode = 0, range = 0;
        QuickSort(n, 0, n.Length - 1);

        arithmeticMean = GetArithmeticMean(n);
        medianValue = n[n.Length / 2];
        mode = n.Length == 1 ? n[n.Length - 1] : GetMode(n);
        range = n.Length == 1 ? 0 : n[n.Length - 1] - n[0];

        Debug.Log(arithmeticMean);
        Debug.Log(medianValue);
        Debug.Log(mode);
        Debug.Log(range);
    }

    private void Swap(int[] arr, int n, int n2)
    {
        int temp = arr[n];
        arr[n] = arr[n2];
        arr[n2] = temp;
    }

    private int GetPivot(int[] arr, int start, int end)
    {
        int center = (start + end) / 2;

        if (arr[start] > arr[center])
            Swap(arr, start, center);

        if (arr[start] > arr[end])
            Swap(arr, start, end);

        if (arr[center] > arr[end])
            Swap(arr, center, end);

        return arr[center];
    }

    private void QuickSort(int[] arr, int start, int end)
    {
        int pivot = GetPivot(arr, start, end);
        int i = start, j = end;

        while (i <= j)
        {
            while (arr[i] < pivot)
                i++;

            while (arr[j] > pivot)
                j--;

            if (i <= j)
            {
                Swap(arr, i, j);
                i++;
                j--;
            }
        }

        if (start < j)
            QuickSort(arr, start, j);

        if (end > i)
            QuickSort(arr, i, end);
    }

    private int GetArithmeticMean(int[] arr)
    {
        int sum = 0;

        foreach (int n in arr)
            sum += n;

        return Mathf.RoundToInt((float)sum / arr.Length);
    }

    private int GetMode(int[] arr)
    {
        int[] arr2 = new int[4001 + arr[arr.Length - 1]];
        int check = 0;
        int mode = 0;

        for (int i = 0; i < arr.Length; i++)
            arr2[4000 + arr[i]]++;

        for (int i = 4000 + arr[0]; i < arr2.Length; i++)
        {
            if (arr2[i] == arr2[arr2.Length - 1])
                check++;

            if (check == 2)
            {
                mode = i - 4000;
                break;
            }
        }

        return mode;
    }
}
