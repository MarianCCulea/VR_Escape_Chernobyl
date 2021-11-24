using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class TimerCountdown : MonoBehaviour
{
  [SerializeField]
  private TextMeshProUGUI textDisplay;
  
  [SerializeField]
  private int secondsLeft;
  
  [SerializeField]
  private bool takingAway = false;
  
  [SerializeField]
  private UnityEvent endTimer;

  void Start()
  {
    textDisplay.text = "00:" + secondsLeft;
  }

  void Update()
  {
    if (takingAway == false && secondsLeft > 0)
    {
      StartCoroutine(TimerTake());
    }else if (secondsLeft < 12)
    {
      endTimer.Invoke();
    }
  }

  IEnumerator TimerTake()
  {
    takingAway = true;
    yield return new WaitForSeconds(1);
    secondsLeft -= 1;
    if (secondsLeft < 10)
    {
      textDisplay.text = "00:0" + secondsLeft;
    }else if (secondsLeft > 59)
    {
      int aux = secondsLeft / 60;
      textDisplay.text = "" + aux + ":" + secondsLeft % 60;
    }
    else
    {
      textDisplay.text = "00:" + secondsLeft;
    }
    takingAway = false;
  }
}
