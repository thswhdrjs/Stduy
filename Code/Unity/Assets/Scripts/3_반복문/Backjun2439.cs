using UnityEngine;

public class Backjun2439 : MonoBehaviour
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

        for (int i = 1; i <= n; i++)
        {
            for (int j = n; j > i; j--)
                star += (" ");

            for (int k = 0; i > k; k++)
                star += ("*");

            star += ("\n");
        }

        Debug.Log(star);
    }
}
