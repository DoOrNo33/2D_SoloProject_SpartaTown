using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMaster : MonoBehaviour
{
    public string Name {  get; set; }
    public int Idx { get; set; } = 0;
    public int Job { get; set; } = 0;

    public void SetName(string _name)
    {
        Name = _name;
    }
}
