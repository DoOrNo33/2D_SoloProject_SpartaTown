using System;
using UnityEngine;
using UnityEngine.UI;
public class TimeUtility : MonoBehaviour
{
    private Text timeLabel;

    private void Awake()
    {
        timeLabel = GetComponent<Text>();
    }
    public string GetCurrentDate()
    {
        return DateTime.Now.ToString("HH:mm");
    }

    private void Update()
    {
        timeLabel.text = GetCurrentDate();
    }
}