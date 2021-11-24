using System.Collections;
using System.Collections.Generic;
using GameFiles.Scripts;
using UnityEngine;

public class Switch : MonoBehaviour
{
    
    [SerializeField]private bool isOn;
    [SerializeField]private int position;
    [SerializeField]private SwitchList switchList;
    public void Activate()
    {
        if (!isOn)
        {
            transform.Rotate(-70, 0, 0, Space.Self);
            isOn = true;
        }

        else
        {
            transform.Rotate(70, 0, 0, Space.Self);
            isOn = false;
        }

        switchList.ChangePosition(position,isOn);
    }

}
