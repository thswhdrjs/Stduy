using UnityEngine;

public class Backjun1436 : MonoBehaviour
{
    private void Start()
    {
        Algorithm(2);
        Algorithm(3);
        Algorithm(6);
        Algorithm(187);
        Algorithm(500);
    }

    private void Algorithm(int n)
    {
        int num = 666;
        int count = 0;

        while (true)
        {
            if (num.ToString().Contains("666"))
                count++;

            if (count == n)
                break;

            num++;
        }

        Debug.Log(num);
    }
}