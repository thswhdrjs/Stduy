using System;
using UnityEngine;

public class Backjun2908 : MonoBehaviour
{
    private void Start()
    {
        Algorithm(734, 893);
        Algorithm(221, 231);
        Algorithm(839, 237);
    }

    private void Algorithm(int n, int n2)
    {
        string s = n.ToString();
        string s2 = n2.ToString();

        string changeS = "";
        string changeS2 = "";

        if (!(99 < n && n < 1000) || !(99 < n2 && n2 < 1000) || Discrimination(s) || Discrimination(s2))
            return;

        changeS = Reverse(s);
        changeS2 = Reverse(s2);

        if (Convert.ToInt32(changeS) > Convert.ToInt32(changeS2))
            Debug.Log(changeS);
        else
            Debug.Log(changeS2);
    }

    private bool Discrimination(string s)
    {
        bool check = false;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i].Equals("0"))
                check = true;
        }

        return check;
    }

    private string Reverse(string s)
    {
        string reverse = "";

        for (int i = s.Length - 1; i >= 0; i--)
            reverse += s[i].ToString();

        return reverse;
    }
}
