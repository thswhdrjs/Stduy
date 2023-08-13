using UnityEngine;

public class Backjun1001 : MonoBehaviour
{
    private void Start()
    {
        Algorithm(3, 2);
    }

    private void Algorithm(int n, int n2)
    {
        if (!(0 < n && n < 10) || !(0 < n2 && n2 < 10))
            return;

        Debug.Log(n - n2);
    }
}
