using UnityEngine;

public class Backjun2588 : MonoBehaviour
{
    private void Start()
    {
        Algorithm(472, 385);
    }

    private void Algorithm(int n, int n2)
    {
        if (!(99 < n && n < 1000) || !(99 < n2 && n2 < 1000))
            return;

        Debug.Log(n * (n2 % 10));
        Debug.Log(n * (n2 / 10 % 10));
        Debug.Log(n * (n2 / 100));
        Debug.Log(n * n2);
    }
}
