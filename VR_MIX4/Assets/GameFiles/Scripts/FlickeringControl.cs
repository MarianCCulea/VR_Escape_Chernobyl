using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickeringControl : MonoBehaviour
{
    public bool isFlickering = false;
    public float timeDeplay;

    void Update()
    {
        if (isFlickering == false)
        {
            StartCoroutine(FlikeringLight());
        }
    }
    
    IEnumerator FlikeringLight()
    {
        isFlickering = true;
        this.gameObject.GetComponent<Light>().enabled = false;
        timeDeplay = Random.Range(0.05f, 0.6f);
        yield return new WaitForSeconds(timeDeplay);
        this.gameObject.GetComponent<Light>().enabled = true;
        timeDeplay = Random.Range(0.05f, 0.6f);
        yield return new WaitForSeconds(timeDeplay);
        isFlickering = false;
    }
}