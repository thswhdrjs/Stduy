using UnityEngine;

public class Backjun1002 : MonoBehaviour
{
    private void Start()
    {
        AlgorithmVer1(0, 0, 13, 40, 0, 37);
        AlgorithmVer2(0, 0, 13, 40, 0, 37);

        AlgorithmVer1(0, 0, 3, 0, 7, 4);
        AlgorithmVer2(0, 0, 3, 0, 7, 4);

        AlgorithmVer1(1, 1, 1, 1, 1, 5);
        AlgorithmVer2(1, 1, 1, 1, 1, 5);
    }

    private void AlgorithmVer1(int x1, int y1, int r1, int x2, int y2, int r2)
    {
        int distancePow = (int)(Mathf.Pow(x2 - x1, 2) + Mathf.Pow(y2 - y1, 2));

        // 원이 일치할 때(무한)
        if (x1 == x2 && y1 == y2 && r1 == r2)
            Debug.Log("-1");
        // 원이 만나지 않을 때(distancePow > Mathf.Pow(r1 + r2, 2))
        else if (distancePow > Mathf.Pow(r1 + r2, 2))
            Debug.Log("0");
        // 원이 만나지 않을 때(distancePow<Mathf.Pow(r2 -r1, 2))
        else if (distancePow < Mathf.Pow(r2 - r1, 2))
            Debug.Log("0");
        // 원이 내접할 때
        else if (distancePow == Mathf.Pow(r2 - r1, 2))
            Debug.Log("1");
        // 원이 외접할 때
        else if (distancePow == Mathf.Pow(r1 + r2, 2))
            Debug.Log("1");
        else
            Debug.Log("2");
    }

    private void AlgorithmVer2(int x1, int y1, int r1, int x2, int y2, int r2)
    {
        float distance = Mathf.Sqrt(Mathf.Pow(x2 - x1, 2) + Mathf.Pow(y2 - y1, 2));

        if (distance == r1 + r2)
            Debug.Log(1);
        else if (distance < r1 + r2 && distance > r1 && distance > r2)
            Debug.Log(2);
        else if (x1 == x2 && y1 == y2 && r1 == r2)
            Debug.Log(-1);
        else
            Debug.Log(0);
    }
}
