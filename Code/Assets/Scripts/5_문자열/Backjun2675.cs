using UnityEngine;

public class Backjun2675 : MonoBehaviour
{
    private void Start()
    {
        Algorithm(3, "ABC");
        Algorithm(5, "/HTP");
    }

    private void Algorithm(int n, string s)
    {
        if (!(1 <= n && n <= 8) || !(1 <= s.Length && s.Length < 20))
            return;

        string output = "";

        for (int i = 0; i < s.Length; i++)
        {
            for (int j = 0; j < n; j++)
            {
                output += s[i];
            }
        }

        Debug.Log(output);
    }
}
