using System;
using UnityEngine;

public class Backjun10757 : MonoBehaviour
{
    private void Start()
    {
        Algorithm("9223372036854775807", "9223372036854775808");
    }

    private void Algorithm(string s, string s2)
    {
        int[] n = new int[s.Length];
        int[] n2 = new int[s2.Length];

        int sLength = s.Length;
        int s2Length = s2.Length;
        int sumLength = s.Length > s2.Length ? s.Length : s2.Length;
        int[] sum = new int[sumLength];

        string output = "";

        for (int i = 0; i < s.Length; i++)
            n[i] = Int32.Parse(s[i].ToString());

        for (int i = 0; i < s2.Length; i++)
            n2[i] = Int32.Parse(s2[i].ToString());

        for (int i = sumLength - 1; i >= 0; i--)
        {
            sLength--;
            s2Length--;
            sum[i] = n[sLength] + n2[s2Length];

            if (sum[i] > 9 && i != 0)
            {
                n[sLength - 1] += 1;
                sum[i] -= 10;
            }
        }

        if (sum[0] == 0)
            sum[0] = 10;

        for (int i = 0; i < sumLength; i++)
            output += sum[i].ToString();

        Debug.Log(output);
    }
}
