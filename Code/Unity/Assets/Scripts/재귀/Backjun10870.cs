using UnityEngine;

public class Backjun10870 : MonoBehaviour
{
    private void Start()
    {
        Debug.Log(Algorithm(10));
    }

    private int Algorithm(int n)
    {
        if (n == 0)
            return 0;
        else if (n == 1)
            return 1;
        else
            return Algorithm(n - 1) + Algorithm(n - 2);
    }
}
