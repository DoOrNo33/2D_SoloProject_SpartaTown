using UnityEditor.SceneManagement;
using UnityEngine;

public class ChangeCharacter : MonoBehaviour
{
    private ChangeUIController _changeUIController;

    private static readonly int isKnight = Animator.StringToHash("isKnight");
    private static readonly int isElf = Animator.StringToHash("isElf");

    private void Awake()
    {
        _changeUIController = GetComponent<ChangeUIController>();
    }

    public void CloseSelectKnight()
    {
        _changeUIController.OffCharacterUI();
        GameManager.Instance.SelectAnimator.SetBool(isKnight, true);
        GameManager.Instance.SelectAnimator.SetBool(isElf, false);
    }

    public void CloseSelectElf()
    {
        _changeUIController.OffCharacterUI();
        GameManager.Instance.SelectAnimator.SetBool(isElf, true);
        GameManager.Instance.SelectAnimator.SetBool(isKnight, false);
    }
}