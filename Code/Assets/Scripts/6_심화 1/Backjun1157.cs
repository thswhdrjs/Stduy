using System;
using UnityEngine;

public class Backjun1157 : MonoBehaviour
{
    private void Start()
    {
        Algorithm("Mississipi");
        Algorithm("zZa");
        Algorithm("z");
        Algorithm("baaa");
    }

    private void Algorithm(string s)
    {
        if (!(1 <= s.Length && s.Length < 1000001))
            return;

        int[] capitalLetter = new int[26];
        int[] smallLetter = new int[26];

        int[] capitalMax = new int[3];
        int[] smallMax = new int[3];

        capitalLetter = GetLetter(s, 65, 91);
        smallLetter = GetLetter(s, 97, 123);

        capitalMax = GetMaxValue(capitalLetter);
        smallMax = GetMaxValue(smallLetter);

        if (capitalMax[0] > smallMax[0] || capitalMax[0] == smallMax[0])
            Output(capitalMax);
        else
            Output(smallMax);
    }

    private int[] GetLetter(string s, int startAscii, int endAscii)
    {
        int[] letter = new int[26];

        for (int i = 0; i < s.Length; i++)
        {
            for (int j = startAscii; j < endAscii; j++)
            {
                if (Convert.ToInt32(s[i]) == j)
                    letter[j - startAscii]++;
            }
        }

        return letter;
    }

    private int[] GetMaxValue(int[] letter)
    {
        int[] max = new int[3];

        for (int i = 0; i < letter.Length; i++)
        {
            if (max[0] < letter[i])
            {
                max[0] = letter[i];
                max[1] = i;
                max[2] = 1;
            }
            else if (max[0] == letter[i])
                max[2]++;
        }

        return max;
    }

    private void Output(int[] maxValue)
    {
        if (maxValue[2] > 1)
            Debug.Log("?");
        else
            Debug.Log(Convert.ToChar(maxValue[1] + 65));
    }
}
