using UnityEngine;

public class Backjun4153 : MonoBehaviour
{
    private void Start()
    {
        Algorithm(6, 8, 10);
        Algorithm(25, 52, 60);
        Algorithm(5, 12, 13);
        Algorithm(0, 0, 0);
    }

    private void Algorithm(int n, int n2, int n3)
    {
        if (n == 0 || n2 == 0 || n3 == 0)
        {
            Debug.Log("변의 값은 0 이상이여야 합니다!");
            return;
        }

        int max = GetMax(n, n2);
        max = GetMax(max, n3);

        if (max == n)
            Debug.Log(IsRightTriangle(n2, n3, n) ? "Right" : "Wrong");
        else if (max == n2)
            Debug.Log(IsRightTriangle(n, n3, n2) ? "Right" : "Wrong");
        else
            Debug.Log(IsRightTriangle(n, n2, n3) ? "Right" : "Wrong");
    }

    private int GetMax(int n, int n2)
    {
        return n > n2 ? n : n2;
    }

    private bool IsRightTriangle(int n, int n2, int n3)
    {
        return Mathf.Pow(n3, 2) == Mathf.Pow(n, 2) + Mathf.Pow(n2, 2);
    }
}
