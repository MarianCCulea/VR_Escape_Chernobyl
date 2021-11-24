using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FuseBox : MonoBehaviour
{

    private bool a, b;
    [SerializeField] private UnityEvent triggerTrue;
    [SerializeField] private UnityEvent triggerFalse;

    public void ActivateFirstFuse()
    {
        a = true;
    }
    
    public void ActivateSecondFuse()
    {
        b = true;
    }
    
    public void DeactivateFirstFuse()
    {
        a = false;
    }
    
    public void DeactivateSecondFuse()
    {
        b = true;
    }
    
    public void LeverTrigger()
    {
        if (a && b)
        {
            triggerTrue.Invoke();
        }
        else
        {
            triggerFalse.Invoke();
        }
    }
    
}
