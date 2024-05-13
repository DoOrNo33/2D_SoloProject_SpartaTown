using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class ChangeUIController : MonoBehaviour
{
    public void SetUI()
    {
        GameManager.Instance.ChangeNameUITrue();
    }

    public void SetCharacterUI()
    {
        Time.timeScale = 0f;
        GameManager.Instance.ChangeCharacterUI.SetActive(true);
    }

    public void OffCharacterUI()
    {
        Time.timeScale = 1f;
        GameManager.Instance.ChangeCharacterUI.SetActive(false);
    }
}