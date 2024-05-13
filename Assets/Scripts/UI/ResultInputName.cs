using UnityEngine;
using UnityEngine.UI;

public class ResultInputName : MonoBehaviour
{
    public InputField playerNameInput;
    private string playerName = null;

    private void Awake()
    {
        playerName = playerNameInput.GetComponent<InputField>().text;
    }

    public void InputName()
    {
        playerName = playerNameInput.text;

        if (GetPrintableLength(playerName) <= 10 && GetPrintableLength(playerName) > 1)
        {
            GameManager.Instance.SetPlayerName(playerName);
            GameManager.Instance.SetActiveFalse();
        }
    }

    public void ChangeName()
    {
        playerName = playerNameInput.text;

        if (GetPrintableLength(playerName) <= 10 && GetPrintableLength(playerName) > 1)
        {
            GameManager.Instance.SetPlayerName(playerName);
            GameManager.Instance.ChangeNameUIFalse();
            playerNameInput.text = null;
        }
    }


    private static int GetPrintableLength(string str)
    {
        int length = 0;
        foreach (char c in str)
        {
            if (char.GetUnicodeCategory(c) == System.Globalization.UnicodeCategory.OtherLetter)
            {
                length += 2;
            }
            else
            {
                length += 1;
            }
        }
        return length;
    }
}