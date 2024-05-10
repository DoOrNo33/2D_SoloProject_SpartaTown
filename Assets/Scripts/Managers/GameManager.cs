using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public string playerName;

    public static GameManager Instance;
    public GameObject Canvas;
    public Text NameTextLabel;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(Instance);
        }
        Instance = this;
        Time.timeScale = 0f;
    }

    public void SetActiveFalse()
    {
        Canvas.SetActive(false);
        Time.timeScale = 1f;
    }

    public void SetPlayerName(string name)
    {
        NameTextLabel.text = name.ToString();
    }
}
