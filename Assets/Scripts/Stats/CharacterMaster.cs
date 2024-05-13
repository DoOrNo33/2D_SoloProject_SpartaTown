using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMaster : MonoBehaviour
{
    public enum jobList
    {
        Student,
        Tutor
    }

    [SerializeField] public string Name;
    [SerializeField] public int Idx;
    [SerializeField] public int Job;


    public void SetName(string _name)
    {
        Name = _name;
    }

    public void SetCharacter(string _name, int _idx, int job)
    {
        Name = _name;
        Idx = _idx;
        Job = job;
    }
}
