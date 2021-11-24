using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RandomString : MonoBehaviour
{
    [SerializeField]
    private int minCharAmount;
    
    [SerializeField]
    private int maxCharAmount;

    [SerializeField] public TextMeshProUGUI text;
    const string glyphs= "abcdefghijklmnopqrstuvwxyz!$%*&^";
    public static string myString = "";
    // Start is called before the first frame update
    void Start()
    {
        int charAmount = Random.Range(minCharAmount, maxCharAmount); //set those to the minimum and maximum length of your string
        for(int i=0; i<charAmount; i++)
        {
            myString += glyphs[Random.Range(0, glyphs.Length)];
        }

        text.text = myString;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
