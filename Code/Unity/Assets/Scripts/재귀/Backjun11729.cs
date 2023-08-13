using UnityEngine;

public class Backjun11729 : MonoBehaviour
{
    private void Start()
    {
        Algorithm(3);
    }

    private void Algorithm(int n)
    {
        Debug.Log(Mathf.Pow(2, n) - 1);
        Hanoi(n, 1, 3, 2);
    }

    private void Hanoi(int n, int start, int to, int via)
    {
        if (n == 1)
        {
            Debug.LogFormat("{0} {1}", start, to, n);
            return;
        }

        Hanoi(n - 1, start, via, to);
        Debug.LogFormat("{0} {1}", start, to, n);
        Hanoi(n - 1, via, to, start);
    }
}
