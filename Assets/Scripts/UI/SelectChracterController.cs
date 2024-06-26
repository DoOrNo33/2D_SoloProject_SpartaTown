using UnityEngine;

public class SelectChracterController : MonoBehaviour
{
    public GameObject SelectWindow;
    public GameObject SelectKnight;
    public GameObject SelectElf;

    private static readonly int isKnight = Animator.StringToHash("isKnight");
    private static readonly int isElf = Animator.StringToHash("isElf");

    public void OpenSelectWindow()
    {
        SelectWindow.SetActive(true);
    }

    public void CloseSelectKnight()
    {

        SelectWindow.SetActive(false);
        SelectKnight.SetActive(true);
        SelectElf.SetActive(false);
        GameManager.Instance.SelectAnimator.SetBool(isKnight, true);
        GameManager.Instance.SelectAnimator.SetBool(isElf, false);
    }

    public void CloseSelectElf()
    {
        SelectWindow.SetActive(false);
        SelectElf.SetActive(true);
        SelectKnight.SetActive(false);
        GameManager.Instance.SelectAnimator.SetBool(isElf, true);
        GameManager.Instance.SelectAnimator.SetBool(isKnight, false);
    }
}