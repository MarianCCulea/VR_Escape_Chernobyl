using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMat : MonoBehaviour
{
    
    [SerializeField] Material mat;
    [SerializeField] Color triggerColor;
    
    private void Start()
    {
        mat.EnableKeyword("_EMISSION");
    }

    public void TriggerChange()
    {
        mat.SetColor("_EmissionColor", triggerColor);
    }
}
