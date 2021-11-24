using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class KeyboardController : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI screenText;
    
    [SerializeField]
    private UnityEvent evnt;

    private void Start()
    {
        screenText.text = "";
    }

    public void onPress(string key)
    {
        screenText.text += key;
        
    }
    
    public void onEnter()
    {
        if (RandomString.myString.Equals(screenText.text))
        {
           evnt.Invoke();
        }
    }

    public void onBackspace()
    {
        screenText.text = screenText.text.Remove(screenText.text.Length - 1);
    }
}
