using System;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public event Action<string> OnNameChangeEvent;

    public void CallNameChangeEvent(string name)
    {
        OnNameChangeEvent?.Invoke(name);
    }

}