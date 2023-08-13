using UnityEngine;

public class Backjun27866 : MonoBehaviour
{
    private void Start()
    {
        Algorithm("Sprout", 3);
        Algorithm("shiftpsh", 6);
        Algorithm("Baekjoon", 4);
    }

    private void Algorithm(string s, int i)
    {
        Debug.Log(s[i - 1]);
    }
}
