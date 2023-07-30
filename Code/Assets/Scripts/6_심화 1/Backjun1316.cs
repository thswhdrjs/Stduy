using System;
using UnityEngine;

public class Backjun1316 : MonoBehaviour
{
    string[][] data = new string[6][]
    {
        new string[]{ "happy", "new", "year" },
        new string[]{ "aba", "abab", "abcabc", "a" },
        new string[]{ "ab", "aa", "aca", "ba", "bb" },
        new string[]{ "yzyzy", "zyzyz" },
        new string[]{ "z" },
        new string[]{ "aaa", "aaazbz", "babb", "aazz", "azbz", "aabbaa", "abacc", "aba", "zzaz" }
    };

    private void Start()
    {
        Algorithm(3, data[0]);
        Algorithm(4, data[1]);
        Algorithm(5, data[2]);
        Algorithm(2, data[3]);
        Algorithm(1, data[4]);
        Algorithm(9, data[5]);
    }

    private void Algorithm(int n, string[] s)
    {
        if (!(0 < s.Length && s.Length <= 100) || !(0 < s.Length && s.Length <= 100))
            return;

        int sum = 0;
        bool[] isGroupWord = new bool[n];

        for (int i = 0; i < s.Length; i++)
        {
            bool[] letter = new bool[26];

            for (int j = 0; j < s[i].Length; j++)
            {
                for (int k = 97; k < 123; k++)
                {
                    if (Convert.ToInt32(s[i][j]) == k)
                    {
                        int index = 1;

                        while (true)
                        {
                            if (j + index == s[i].Length)
                            {
                                index -= 1;
                                break;
                            }

                            if (s[i][j] != s[i][j + index])
                            {
                                index -= 1;
                                break;
                            }

                            index++;
                        }

                        j += index;

                        if (!letter[k - 97])
                            letter[k - 97] = true;
                        else
                        {
                            if (j < s[i].Length)
                                isGroupWord[i] = true;
                        }


                        break;
                    }
                }
            }
        }

        for (int i = 0; i < isGroupWord.Length; i++)
        {
            if (!isGroupWord[i])
                sum++;
        }

        Debug.Log(sum);
    }
}
