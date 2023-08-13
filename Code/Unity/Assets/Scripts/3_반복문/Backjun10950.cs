using UnityEngine;

public class Backjun10950 : MonoBehaviour
{
    private void Start()
    {
        Algorithm(1, 1);
        Algorithm(2, 3);
        Algorithm(3, 4);
        Algorithm(9, 8);
        Algorithm(5, 2);
    }

    private void Algorithm(int n, int n2)
    {
        Debug.Log(n + n2);
    }
}
