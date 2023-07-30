using UnityEngine;

public class Backjun1011 : MonoBehaviour
{
    private void Start()
    {
        Algorithm(0, 3);
        Algorithm(1, 5);
        Algorithm(45, 50);
    }

    private void Algorithm(int n, int n2)
    {
        if (n > n2)
            return;

        int distance = n2 - n;
        int max = (int)Mathf.Sqrt(distance);

        if (Mathf.Sqrt(distance) - max == 0)
            Debug.Log(max * 2 - 1);
        else if (distance <= max * max + max)
            Debug.Log(max * 2);
        else
            Debug.Log(max * 2 + 1);
    }
}
