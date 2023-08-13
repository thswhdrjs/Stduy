using UnityEngine;

public class Backjun1008 : MonoBehaviour
{
    private void Start()
    {
        Algorithm(1, 3);
        Algorithm(4, 5);
    }

    private void Algorithm(int n, int n2)
    {
        if (!(0 < n && n < 10) || !(0 < n2 && n2 < 10))
            return;

        Debug.Log(n / n2);
    }
}
