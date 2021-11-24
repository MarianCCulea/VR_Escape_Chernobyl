using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class LockDrawers : MonoBehaviour
{
    [SerializeField]
    private GameObject[] list;
    
    
    [SerializeField]
    private Material lockedMat;
    
    
    [SerializeField]
    private Material unlockedMat;

    public void unlockDrawer(int nr)
    {
        list[nr].GetComponent<Rigidbody>().constraints &= ~RigidbodyConstraints.FreezePositionZ;
        list[nr].GetComponent<MeshRenderer>().material=unlockedMat;
    }

    private void Start()
    {
        for (int i = 0; i<list.Length; i++)
        {
            // list[i].GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionZ;
            // list[i].GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX;
            // list[i].GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionY;
            // list[i].GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationX;
            // list[i].GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationY;
            // list[i].GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationY;
            list[i].GetComponent<MeshRenderer>().material=lockedMat;
        }
    }
}
