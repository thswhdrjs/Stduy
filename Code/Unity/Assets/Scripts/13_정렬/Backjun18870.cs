using UnityEngine;

public class Backjun18870 : MonoBehaviour
{
    int[] data = new int[] { 2, 4, -10, 4, -9 };
    int[] data2 = new int[] { 1000, 999, 1000, 999, 1000, 999 };

    private void Start()
    {
        Algorithm(data);
        Algorithm(data2);
    }

    private void Algorithm(int[] n)
    {
        int order = 0;
        int[] arr = new int[n.Length];

        for (int i = 0; i < n.Length; i++)
            arr[i] = n[i];

        QuickSort(arr, 0, arr.Length - 1);

        for (int i = 0; i < n.Length - 1; i++)
        {
            for (int j = i + 1; j < n.Length; j++)
            {
                if (arr[i] == arr[j])
                    arr[j] = 0;
            }
        }

        for (int i = 0; i < n.Length; i++)
        {
            if (arr[i] == 0)
                continue;

            for (int j = 0; j < n.Length; j++)
            {
                if (arr[i] == n[j])
                    n[j] = order;
            }

            order++;
        }

        for (int i = 0; i < n.Length; i++)
            Debug.Log(n[i]);
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
