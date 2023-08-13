using UnityEngine;

public class Backjun2741 : MonoBehaviour
{
    private void Start()
    {
        Algorithm(10);
    }

    private void Algorithm(int n)
    {
        if (!(0 < n && n <= 100000))
            return;

        for (int i = 1; i < n + 1; i++)
            Debug.Log(i);
    }
}
