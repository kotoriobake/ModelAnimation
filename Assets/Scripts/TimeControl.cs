using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeControl : MonoBehaviour
{
    public Slider slider;

    void Start()
    {
        Time.fixedDeltaTime = slider.value;
    }

    public void ChangeFixedTime(float time)
    {
        Time.fixedDeltaTime = time;
    }
}
