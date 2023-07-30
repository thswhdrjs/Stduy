using UnityEngine;

public class Backjun2525 : MonoBehaviour
{
    private void Start()
    {
        Algorithm(14, 30, 20);
        Algorithm(17, 40, 80);
        Algorithm(23, 48, 25);
    }

    private void Algorithm(int hour, int minute, int required)
    {
        int requiredTime = minute + required, calculateHour = requiredTime / 60;
        hour += calculateHour;
        minute = requiredTime % 60;

        if (hour + calculateHour > 23)
            hour -= 24;

        Debug.Log(hour + " " + minute);
    }
}
