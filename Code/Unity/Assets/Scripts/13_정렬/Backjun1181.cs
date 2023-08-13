using System;
using UnityEngine;

public class Backjun1181 : MonoBehaviour
{
    string[] data = new string[13]
    {
        "but",
        "i",
        "wont",
        "hesitate",
        "no",
        "more",
        "no",
        "more",
        "it",
        "cannot",
        "wait",
        "im",
        "yours"
    };

    private void Start()
    {
        Algorithm(data);
    }

    private void Algorithm(string[] n)
    {
        Array.Sort(n, (s, s2) =>
        {
            if (s.Length == s2.Length)
            {
                int compare = 0;

                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == s2[i])
                        continue;

                    compare = Convert.ToInt32(s[i]) - Convert.ToInt32(s2[i]);
                    break;
                }

                return compare;
            }
            else
                return s.Length - s2.Length;
        });

        for (int i = 0; i < n.Length; i++)
        {
            bool isExit = false;

            for (int j = 0; j < i; j++)
            {
                if (n[i] == n[j])
                {
                    isExit = true;
                    break;
                }
            }

            if (isExit)
                n[i] = "";
        }

        for (int i = 0; i < n.Length; i++)
        {
            if (n[i] != "")
                Debug.Log(n[i]);
        }
    }
}
