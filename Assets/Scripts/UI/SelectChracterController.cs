using UnityEngine;

public class SelectChracterController : MonoBehaviour
{
    public GameObject SelectWindow;
    public GameObject SelectKnight;
    public GameObject SelectElf;

    public void OpenSelectWindow()
    {
        SelectWindow.SetActive(true);
    }

    public void CloseSelectKnight()
    {

        SelectWindow.SetActive(false);
        SelectKnight.SetActive(true);
        SelectElf.SetActive(false);
    }

    public void CloseSelectElf()
    {
        SelectWindow.SetActive(false);
        SelectElf.SetActive(true);
        SelectKnight.SetActive(false);
    }
}