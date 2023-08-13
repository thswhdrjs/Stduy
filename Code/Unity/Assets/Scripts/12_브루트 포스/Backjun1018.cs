using UnityEngine;

public class Backjun1018 : MonoBehaviour
{
    string[][] data = new string[8][]
    {
        new string[]{"W", "B", "W", "B", "W", "B", "W", "B"},
        new string[]{"B", "W", "B", "W", "B", "W", "B", "W"},
        new string[]{"W", "B", "W", "B", "W", "B", "W", "B"},
        new string[]{"B", "W", "B", "B", "B", "W", "B", "W"},
        new string[]{"W", "B", "W", "B", "W", "B", "W", "B"},
        new string[]{"B", "W", "B", "W", "B", "W", "B", "W"},
        new string[]{"W", "B", "W", "B", "W", "B", "W", "B"},
        new string[]{"B", "W", "B", "W", "B", "W", "B", "W"}
    };

    string[][] data2 = new string[10][]
    {
        new string[]{"B", "B", "B", "B", "B", "B", "B", "B", "W", "B", "W", "B", "W"},
        new string[]{"B", "B", "B", "B", "B", "B", "B", "B", "B", "W", "B", "W", "B"},
        new string[]{"B", "B", "B", "B", "B", "B", "B", "B", "W", "B", "W", "B", "W"},
        new string[]{"B", "B", "B", "B", "B", "B", "B", "B", "B", "W", "B", "W", "B"},
        new string[]{"B", "B", "B", "B", "B", "B", "B", "B", "W", "B", "W", "B", "W"},
        new string[]{"B", "B", "B", "B", "B", "B", "B", "B", "B", "W", "B", "W", "B"},
        new string[]{"B", "B", "B", "B", "B", "B", "B", "B", "W", "B", "W", "B", "W"},
        new string[]{"B", "B", "B", "B", "B", "B", "B", "B", "B", "W", "B", "W", "B"},
        new string[]{"W", "W", "W", "W", "W", "W", "W", "W", "W", "W", "B", "W", "B"},
        new string[]{"W", "W", "W", "W", "W", "W", "W", "W", "W", "W", "B", "W", "B"}
    };

    string[][] data3 = new string[8][]
    {
        new string[]{"B", "W", "B", "W", "B", "W", "B", "W"},
        new string[]{"W", "B", "W", "B", "W", "B", "W", "B"},
        new string[]{"B", "W", "B", "W", "B", "W", "B", "W"},
        new string[]{"W", "B", "W", "B", "W", "B", "W", "B"},
        new string[]{"B", "W", "B", "W", "B", "W", "B", "W"},
        new string[]{"W", "B", "W", "B", "W", "B", "W", "B"},
        new string[]{"B", "W", "B", "W", "B", "W", "B", "W"},
        new string[]{"W", "B", "W", "B", "W", "B", "W", "B"}
    };

    string[][] data4 = new string[9][]
    {
        new string[]{"B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B"},
        new string[]{"B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B"},
        new string[]{"B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B"},
        new string[]{"B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B"},
        new string[]{"B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B"},
        new string[]{"B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B"},
        new string[]{"B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B"},
        new string[]{"B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B"},
        new string[]{"B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "W"}
    };

    string[][] data5 = new string[10][]
    {
        new string[]{"B", "B", "B", "B", "B", "B", "B", "B", "B", "B"},
        new string[]{"B", "B", "W", "B", "W", "B", "W", "B", "W", "B"},
        new string[]{"B", "W", "B", "W", "B", "W", "B", "W", "B", "B"},
        new string[]{"B", "B", "W", "B", "W", "B", "W", "B", "W", "B"},
        new string[]{"B", "W", "B", "W", "B", "W", "B", "W", "B", "B"},
        new string[]{"B", "B", "W", "B", "W", "B", "W", "B", "W", "B"},
        new string[]{"B", "W", "B", "W", "B", "W", "B", "W", "B", "B"},
        new string[]{"B", "B", "W", "B", "W", "B", "W", "B", "W", "B"},
        new string[]{"B", "W", "B", "W", "B", "W", "B", "W", "B", "B"},
        new string[]{"B", "B", "B", "B", "B", "B", "B", "B", "B", "B"},
    };

    string[][] data6 = new string[8][]
    {
        new string[]{"W", "B", "W", "B", "W", "B", "W", "B"},
        new string[]{"B", "W", "B", "W", "B", "W", "B", "W"},
        new string[]{"W", "B", "W", "B", "W", "B", "W", "B"},
        new string[]{"B", "W", "B", "B", "B", "W", "B", "W"},
        new string[]{"W", "B", "W", "B", "W", "B", "W", "B"},
        new string[]{"B", "W", "B", "W", "B", "W", "B", "W"},
        new string[]{"W", "B", "W", "B", "W", "W", "W", "B"},
        new string[]{"B", "W", "B", "W", "B", "W", "B", "W"}
    };

    string[][] data7 = new string[11][]
    {
        new string[]{"B", "W", "W", "B", "W", "W", "B", "W", "W", "B", "W", "W"},
        new string[]{"B", "W", "W", "B", "W", "B", "B", "W", "W", "B", "W", "W"},
        new string[]{"W", "B", "W", "W", "B", "W", "B", "B", "W", "W", "B", "W"},
        new string[]{"B", "W", "W", "B", "W", "B", "B", "W", "W", "B", "W", "W"},
        new string[]{"W", "B", "W", "W", "B", "W", "B", "B", "W", "W", "B", "W"},
        new string[]{"B", "W", "W", "B", "W", "B", "B", "W", "W", "B", "W", "W"},
        new string[]{"W", "B", "W", "W", "B", "W", "B", "B", "W", "W", "B", "W"},
        new string[]{"B", "W", "W", "B", "W", "B", "W", "W", "W", "B", "W", "W"},
        new string[]{"W", "B", "W", "W", "B", "W", "B", "B", "W", "W", "B", "W"},
        new string[]{"B", "W", "W", "B", "W", "B", "B", "W", "W", "B", "W", "W"},
        new string[]{"W", "B", "W", "W", "B", "W", "B", "B", "W", "W", "B", "W"}
    };

    private void Start()
    {
        Algorithm(8, 8, data);
        Algorithm(10, 13, data2);
        Algorithm(8, 8, data3);
        Algorithm(9, 23, data4);
        Algorithm(10, 10, data5);
        Algorithm(8, 8, data6);
        Algorithm(11, 12, data7);
    }

    private void Algorithm(int n, int n2, string[][] chessBoard)
    {
        int min = -1;
        int blackCount = 0;
        int whiteCount = 0;

        for (int i = 0; i < n - 7; i++)
        {
            for (int j = 0; j < n2 - 7; j++)
            {
                for (int k = i; k < i + 8; k++)
                {
                    for (int l = j; l < j + 8; l++)
                    {
                        if (k % 2 == 0)
                        {
                            if (l % 2 == 0)
                            {
                                if (chessBoard[k][l].Equals("W"))
                                    whiteCount++;
                                else
                                    blackCount++;
                            }
                            else
                            {
                                if (chessBoard[k][l].Equals("B"))
                                    whiteCount++;
                                else
                                    blackCount++;
                            }
                        }
                        else
                        {
                            if (l % 2 == 0)
                            {
                                if (chessBoard[k][l].Equals("B"))
                                    whiteCount++;
                                else
                                    blackCount++;
                            }
                            else
                            {
                                if (chessBoard[k][l].Equals("W"))
                                    whiteCount++;
                                else
                                    blackCount++;
                            }
                        }
                    }
                }

                if (min == -1)
                    min = Mathf.Min(blackCount, whiteCount);
                else
                {
                    if (min > blackCount || min > whiteCount)
                        min = Mathf.Min(blackCount, whiteCount);
                }

                blackCount = 0;
                whiteCount = 0;
            }
        }

        Debug.Log(min);
    }
}
