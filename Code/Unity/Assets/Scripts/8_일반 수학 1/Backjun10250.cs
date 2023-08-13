using UnityEngine;

public class Backjun10250 : MonoBehaviour
{
    private void Start()
    {
        Algorithm(6, 12, 10);
        Algorithm(30, 50, 72);
    }

    private void Algorithm(int n, int n2, int n3)
    {
        if (!(0 < n && n < 100) || !(0 < n2 && n2 < 100) || !(0 < n3 && n3 <= n * n2))
            return;

        int floor = n3 % n;
        int nRoom = n3 / n + 1;

        if (nRoom < 10)
            Debug.Log(floor + "0" + nRoom);
        else
            Debug.Log(floor + "" + nRoom);
    }
}
