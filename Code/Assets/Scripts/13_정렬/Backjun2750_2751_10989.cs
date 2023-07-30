using UnityEngine;

public class Backjun2750_2751_10989 : MonoBehaviour
{
    int[] data = new int[5] { 5, 2, 3, 4, 1 };
    int[] data2 = new int[10] { 5, 2, 3, 1, 4, 2, 3, 5, 1, 7 };

    private void Start()
    {
        Algorithm(data);
        Algorithm(data2);
    }

    private void Algorithm(int[] n)
    {
        QuickSort(n, 0, n.Length - 1);

        foreach (int num in n)
            Debug.Log(num);
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
}
