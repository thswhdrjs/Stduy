using UnityEngine;

public class Backjun2480 : MonoBehaviour
{
    private void Start()
    {
        Algorithm(3, 3, 6);
        Algorithm(2, 2, 2);
        Algorithm(6, 2, 5);
    }

    private void Algorithm(int n, int n2, int n3)
    {
        int same = 0, sameScore = 0;

        if (n == n2)
        {
            same += 1;
            sameScore = n;
        }
            
        if (n == n3)
        {
            same += 1;
            sameScore = n;
        }

        if (n2 == n3)
        {
            same += 1;
            sameScore = n2;
        }

        switch (same)
        {
            case 0:
                {
                    Debug.Log(100 * Mathf.Max(n, Mathf.Max(n2, n3)));
                    break;
                }
            default:
                {
                    Debug.Log(1000 + sameScore * 100);
                    break;
                }
            case 3:
                {
                    Debug.Log(10000 + sameScore * 1000);
                    break;
                }
        }
        
    }
}
