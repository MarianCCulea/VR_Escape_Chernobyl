using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandAnimationControl : MonoBehaviour
{
    [SerializeField] private Animator handAnimator;
    [SerializeField] private InputActionReference gripAction;

    private void OnEnable()
    {
        gripAction.action.performed += GripAnimation;
    }

    private void GripAnimation(InputAction.CallbackContext obj)
    {
        handAnimator.SetFloat("Grip",obj.ReadValue<float>());
    }
    
}
