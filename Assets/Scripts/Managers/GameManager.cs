using System;
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
    public GameObject MemberListUI;
    public Text MemberListText;
    public Text NameTextLabel;

    public List<string> CurrentMemeber;

    public Animator SelectAnimator;       // animator ��Ʈ��

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(Instance);
        }
        Instance = this;
        Time.timeScale = 1f;
        //Time.timeScale = 0f;

        CurrentMemeber.Add("������");
        CurrentMemeber.Add("���¿�");
        CurrentMemeber.Add("������");


    }

    private void Start()
    {
        SetMemeberName();
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

    public void SetMemeberName()
    {
        MemberListText.text = (CurrentMemeber[0] + "\n" + CurrentMemeber[1] + "\n" + CurrentMemeber[2]).ToString();
    }
}
