using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorQuest : MonoBehaviour
{
    public GameObject questUI;
    public GameObject dialogUI;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            questUI.SetActive(true);
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            questUI.SetActive(false);
            dialogUI.SetActive(false);
        }
    }

    public void QuestStart()
    {
        questUI.SetActive(false);
        dialogUI.SetActive(true);
    }

    public void QuestFinish()
    {
        dialogUI.SetActive(false);
    }
}
