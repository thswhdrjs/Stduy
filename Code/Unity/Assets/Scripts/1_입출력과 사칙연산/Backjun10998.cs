using UnityEngine;

public class Backjun10998 : MonoBehaviour
{
    private void Start()
    {
        Algorithm(1, 2);
        Algorithm(3, 4);
    }

    private void Algorithm(int n, int n2)
    {
        if (!(0 < n && n < 10) || !(0 < n2 && n2 < 10))
            return;

        Debug.Log(n * n2);
    }
}
