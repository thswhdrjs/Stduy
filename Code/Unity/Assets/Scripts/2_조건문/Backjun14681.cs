using UnityEngine;

public class Backjun14681 : MonoBehaviour
{
    private void Start()
    {
        Algorithm(12, 5);
        Algorithm(9, -13);
    }

    private void Algorithm(int n, int n2)
    {
        if (!(-1000 <= n && n <= 1000 && n != 0) || !(-1000 <= n2 && n2 <= 1000 && n2 != 0))
            return;

        if (n > 0)
        {
            if (n2 > 0)
                Debug.Log("1");
            else
                Debug.Log("4");
        }
        else
        {
            if (n2 > 0)
                Debug.Log("2");
            else
                Debug.Log("3");
        }
    }
}
