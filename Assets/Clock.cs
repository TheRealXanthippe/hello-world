using UnityEngine;
using System;

public class Clock : MonoBehaviour
{
    const float
        degreesPerHour = 30f,
        degreesPerMinute = 6f,
        degreesPerSecond = 6f;
    // Start is called before the first frame update
    public Transform hoursTransform, minutesTransform, secondsTransform;
    public bool continuous;

    void UpdateContinuous()
    {
        TimeSpan time = DateTime.Now.TimeOfDay;
        hoursTransform.localRotation = 
            Quaternion.Euler(0f, (float)time.TotalHours * degreesPerHour, 0f);
        hoursTransform.localRotation =
            Quaternion.Euler(0f, (float)time.TotalMinutes * degreesPerMinute, 0f);
        hoursTransform.localRotation =
            Quaternion.Euler(0f, (float)time.TotalSeconds * degreesPerSecond, 0f);

    }

    void UpdateDiscrete()
    {
        DateTime time = DateTime.Now;
        hoursTransform.localRotation =
            Quaternion.Euler(0f, (float)time.Hour * degreesPerHour, 0f);
        hoursTransform.localRotation =
            Quaternion.Euler(0f, (float)time.Minute * degreesPerMinute, 0f);
        hoursTransform.localRotation =
            Quaternion.Euler(0f, (float)time.Second * degreesPerSecond, 0f);

    }

    void Update()
    {
        if (continuous)
        {
            UpdateContinuous();
        }
        else
        {
            UpdateDiscrete();
        }
    }
}

         
  
