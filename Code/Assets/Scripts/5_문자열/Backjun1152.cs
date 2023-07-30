using UnityEngine;

public class Backjun1152 : MonoBehaviour
{
    private void Start()
    {
        Algorithm("The Curious Case of Benjamin Button");
        Algorithm("The first character is a blank");
        Algorithm("The last character is a blank");
    }

    private void Algorithm(string s)
    {
        if (!(0 < s.Length && s.Length < 1000001))
            return;

        int count = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == ' ')
                count++;
        }

        Debug.Log(count + 1);
    }
}
