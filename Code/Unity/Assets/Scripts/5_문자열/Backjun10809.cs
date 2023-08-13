using System;
using UnityEngine;

public class Backjun10809 : MonoBehaviour
{
    private void Start()
    {
        Algorithm("baekjoon");
    }

    private void Algorithm(string s)
    {
        if (!(0 < s.Length && s.Length < 100))
            return;

        int?[] alphabet = new int?[26];
        string output = "";


        for (int i = 0; i < s.Length; i++)
        {
            for (int j = 97; j < 123; j++)
            {
                if (Convert.ToInt32(s[i]) == j && alphabet[j - 97] == null)
                    alphabet[j - 97] = i;
            }
        }

        for (int i = 0; i < alphabet.Length; i++)
        {
            if (alphabet[i] == null)
                alphabet[i] = -1;

            output += alphabet[i];
            output += " ";
        }

        Debug.Log(output);
    }
}
