using UnityEngine;

public class Backjun10430 : MonoBehaviour
{
    private void Start()
    {
        Algorithm(5, 8, 4);
    }

    private void Algorithm(int n, int n2, int n3)
    {
        if (!(2 <= n && n <= 10000) || !(2 <= n2 && n2 <= 10000) || !(2 <= n3 && n3 <= 10000))
            return;

        Debug.Log((n + n2) % n3);
        Debug.Log(n % n3 + n2 % n3 % n3);
        Debug.Log(n * n2 % n3);
        Debug.Log((n % n3) * (n2 % n3) % n3);
    }
}
