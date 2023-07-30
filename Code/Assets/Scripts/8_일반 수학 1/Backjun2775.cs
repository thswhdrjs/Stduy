using UnityEngine;

public class Backjun2775 : MonoBehaviour
{
    private void Start()
    {
        Algorithm(1, 3);
        Algorithm(2, 3);
    }

    private void Algorithm(int n, int n2)
    {
        if (!(0 < n && n < 15) || !(0 < n2 && n2 < 15))
            return;

        //재귀
        Debug.Log(GetRoomPerson(n, n2));

        //이차 배열
        int[,] room = new int[n + 1, n2];

        for (int i = 1; i < n + 1; i++)
            room[i, 0] = 1;

        for (int i = 0; i < n2; i++)
            room[0, i] = i + 1;

        for (int i = 1; i < n + 1; i++)
        {
            for (int j = 1; j < n2; j++)
                room[i, j] = room[i, j - 1] + room[i - 1, j];
        }

        Debug.Log(room[n, n2 - 1]);
    }

    private int GetRoomPerson(int floor, int nRoom)
    {
        if (floor == 0)
            return nRoom;
        else if (nRoom == 1)
            return 1;

        return GetRoomPerson(floor, nRoom - 1) + GetRoomPerson(floor - 1, nRoom);
    }
}
