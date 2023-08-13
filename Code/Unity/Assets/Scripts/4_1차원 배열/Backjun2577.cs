using UnityEngine;

public class Backjun2577 : MonoBehaviour
{
    private void Start()
    {
        Algorithm(150, 266, 427);
    }

    private void Algorithm(int n, int n2, int n3)
    {
        int digit = 0;
        int multiplication = n * n2 * n3;

        for (int i = 8; i < 11; i++)
        {
            if (multiplication / (int)Mathf.Pow(10, i) == 0)
            {
                digit = i;
                break;
            }
        }

        int[] num = new int[10];
        int[] arr = new int[digit];
        arr[0] = multiplication / (int)Mathf.Pow(10, digit);

        for (int i = 1; i < arr.Length; i++)
            arr[i] = multiplication / (int)Mathf.Pow(10, digit - i) % 10;

        for (int i = 0; i < arr.Length; i++)
        {
            switch (arr[i])
            {
                case 0:
                    {
                        num[0]++;
                        break;
                    }
                case 1:
                    {
                        num[1]++;
                        break;
                    }
                case 2:
                    {
                        num[2]++;
                        break;
                    }
                case 3:
                    {
                        num[3]++;
                        break;
                    }
                case 4:
                    {
                        num[4]++;
                        break;
                    }
                case 5:
                    {
                        num[5]++;
                        break;
                    }
                case 6:
                    {
                        num[6]++;
                        break;
                    }
                case 7:
                    {
                        num[7]++;
                        break;
                    }
                case 8:
                    {
                        num[8]++;
                        break;
                    }
                case 9:
                    {
                        num[9]++;
                        break;
                    }
            }
        }

        for (int i = 0; i < num.Length; i++)
            Debug.Log(num[i]);
    }
}
