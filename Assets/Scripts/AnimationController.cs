using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private int animationVariable = 0;
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        animator.SetInteger("ActionIndex", animationVariable);
        animationVariable++;
        if (animationVariable > 2)
        {
            animationVariable = 0;
        }
        Debug.Log(animationVariable);
    }
}
