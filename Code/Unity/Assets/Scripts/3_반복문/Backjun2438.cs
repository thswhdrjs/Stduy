using UnityEngine;

public class Backjun2438 : MonoBehaviour
{
    private void Start()
    {
        Algorithm(5);
    }

    private void Algorithm(int n)
    {
        if (!(1 <= n && n <= 100))
            return;

        string star = string.Empty;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j <= i; j++)
                star += "*";

            star +="\n";
        }

        Debug.Log(star);
    }
}