using UnityEngine;

public class Backjun2742 : MonoBehaviour
{
    private void Start()
    {
        Algorithm(10);
    }

    private void Algorithm(int n)
    {
        if (!(0 < n && n <= 100000))
            return;

        for (int i = n; i > 0; i--)
            Debug.Log(i);
    }
}
