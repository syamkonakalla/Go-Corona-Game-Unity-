using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text scoret;
    private float scorevalue;

    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Player") != null)
        {
            scorevalue += 1* Time.deltaTime;
            scoret.text=((int)scorevalue).ToString();
        }

        
    }
}
