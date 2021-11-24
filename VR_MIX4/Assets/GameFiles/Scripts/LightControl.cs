using System;
using UnityEngine;
public class LightControl : MonoBehaviour, IDial
    {
        [SerializeField] Material mat;
        [SerializeField] Color sColor;


        private void Start()
        {
            mat.EnableKeyword("_EMISSION");
            mat.SetColor("_EmissionColor", Color.white);
        }

        public void DialChanged(float dialvalue)
        {

            
            if (dialvalue > 250)
            {
                
                mat.SetColor("_EmissionColor", sColor);
            }
            else
            {
                mat.SetColor("_EmissionColor", Color.white);
            }
            
        }

    
    }

