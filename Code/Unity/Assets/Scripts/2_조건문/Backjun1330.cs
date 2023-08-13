using UnityEngine;

public class Backjun1330 : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Algorithm(1, 2);
        Algorithm(10, 2);
        Algorithm(5, 5);
    }

    private void Algorithm(int n, int n2)
    {
        if (!(-10000 <= n && n <= 10000) || !(-10000 <= n2 && n2 <= 10000))
            return;

        if (n > n2)
            Debug.Log(">");
        else if (n < n2)
            Debug.Log("<");
        else
            Debug.Log("==");
    }
}
