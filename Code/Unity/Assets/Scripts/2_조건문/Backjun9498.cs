using UnityEngine;

public class Backjun9498 : MonoBehaviour
{
    private void Start()
    {
        Algorithm(100);
    }

    private void Algorithm(int n)
    {
        if (!(0 <= n && n <= 100))
            return;

        if (n >= 90)
            Debug.Log("A");
        else if (n >= 80)
            Debug.Log("B");
        else if (n >= 70)
            Debug.Log("C");
        else if (n >= 60)
            Debug.Log("D");
        else
            Debug.Log("F");
    }
}
