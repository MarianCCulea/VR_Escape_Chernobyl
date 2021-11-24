using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerLever : MonoBehaviour
{
    [SerializeField]
    private UnityEvent down;
    [SerializeField]
    private UnityEvent up;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localRotation.x > 0.9) 
        {
            down.Invoke();
        }else if (transform.localRotation.x < 0.19 )
        {
            up.Invoke();
        }
    }
}
