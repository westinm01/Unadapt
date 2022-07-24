using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseTime : MonoBehaviour
{
    public void setTime(float t)
    {
        Time.timeScale = t;
    }
}
