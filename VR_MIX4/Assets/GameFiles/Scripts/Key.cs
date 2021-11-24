using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class Key : MonoBehaviour
{
    [SerializeField]
    private string key;
    [SerializeField]
    private KeyboardController controller;

    public void onPress()
    {
        controller.onPress(key);
        
    }

    public void onEnter()
    {
        controller.onEnter();
    }
    
    public void onBackspace()
    {
        controller.onBackspace();
    }
    
    
}
