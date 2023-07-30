using UnityEngine;

public class Backjun2753 : MonoBehaviour
{
    private void Start()
    {
        Algorithm(2000);
        Algorithm(1999);
    }

    private void Algorithm(int n)
    {
        if (!(1 <= n && n <= 4000))
            return;

        if (n % 4 == 0 && (n % 100 != 0 || n % 400 == 0))
            Debug.Log("1");
        else
            Debug.Log("0");
    }
}
