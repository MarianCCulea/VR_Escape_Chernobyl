using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] private int time;
    
    [SerializeField] private UnityEvent timedEvent;
    private void Start()
    {
        StartCoroutine(EndCutScene());
    }

    IEnumerator EndCutScene()
    {
        yield return new WaitForSeconds(time);
        timedEvent.Invoke();
        
    }
}