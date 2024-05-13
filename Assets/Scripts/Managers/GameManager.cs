using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public string playerName;

    public static GameManager Instance;
    public GameObject Canvas;
    public GameObject ChangeNameUI;
    public GameObject ChangeCharacterUI;
    public Text NameTextLabel;

    public Animator SelectAnimator;       // animator ÄÁÆ®·Ñ

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(Instance);
        }
        Instance = this;
        Time.timeScale = 1f;
        //Time.timeScale = 0f;
    }

    public void SetActiveFalse()
    {
        Canvas.SetActive(false);
        //Time.timeScale = 1f;
    }

    public void ChangeNameUIFalse()
    {
        ChangeNameUI.SetActive(false);
        Time.timeScale = 1f;
    }

    public void ChangeNameUITrue()
    {
        ChangeNameUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void CharacterSelectUI()
    {

    }

    public void SetPlayerName(string name)
    {
        NameTextLabel.text = name.ToString();
    }
}
