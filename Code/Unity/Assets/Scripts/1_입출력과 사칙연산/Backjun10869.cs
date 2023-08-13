using UnityEngine;

public class Backjun10869 : MonoBehaviour
{
    private void Start()
    {
        Algorithm(7, 3);
    }

    private void Algorithm(int n, int n2)
    {
        if (!(1 <= n && n <= 10000) || !(1 <= n2 && n2 <= 10000))
            return;

        Debug.Log(n + n2);
        Debug.Log(n - n2);
        Debug.Log(n * n2);
        Debug.Log(n / n2);
        Debug.Log(n % n2);
    }
}
