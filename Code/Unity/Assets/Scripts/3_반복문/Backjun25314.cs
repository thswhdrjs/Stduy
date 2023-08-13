using UnityEngine;

public class Backjun25314 : MonoBehaviour
{
    private void Start()
    {
        Algorithm(4);
        Algorithm(20);
    }

    private void Algorithm(int n)
    {
        string output = "int";

        for(int i = 0; i < n / 4; i++)
        {
            output = "long " + output;
        }

        Debug.Log(output);
    }
}
