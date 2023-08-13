using UnityEngine;

public class Backjun10872 : MonoBehaviour
{
    private void Start()
    {
        Debug.Log(Algorithm(10));
        Debug.Log(Algorithm(0));
    }

    private int Algorithm(int n)
    {
        if (n > 1)
            return n * Algorithm(n - 1);
        else
            return 1;
    }
}
