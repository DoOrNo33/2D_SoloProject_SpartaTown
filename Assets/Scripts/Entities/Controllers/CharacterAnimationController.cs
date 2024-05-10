using System;
using UnityEngine;
using UnityEngine.InputSystem.Utilities;

public class CharacterAnimationController : AnimationController
{
    private static readonly int isRun = Animator.StringToHash("isRun");

    // ¹®ÅÎ - Threshold
    private readonly float magnitudeThreshold = 0.5f; 

    protected override void Awake()
    {
        base.Awake();
    }

    void Start()
    {
        controller.OnMoveEvent += Move;
    }

    private void Move(Vector2 direction)
    {
        animator.SetBool(isRun, direction.magnitude > magnitudeThreshold);
    }
}