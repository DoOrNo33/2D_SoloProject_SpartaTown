using System;
using UnityEngine.UI;

public class NameController : UIManager
{
    public Text Nametext;
    public void Start()
    {
        OnNameChangeEvent += ChangeNameTag;
    }

    public void ChangeNameTag(string tag)
    {
        Nametext.text = tag;
    }

    
}