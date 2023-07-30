using UnityEngine;

public class Backjun9086 : MonoBehaviour
{
    private void Start()
    {
        Algorithm("ACDKJFOWIEGHE");
        Algorithm("O");
        Algorithm("AB");
    }

    private void Algorithm(string s)
    {
        Debug.LogFormat("{0}{1}", s[0], s[s.Length - 1]);
    }
}
