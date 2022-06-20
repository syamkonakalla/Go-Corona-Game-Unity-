using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loopingbackground : MonoBehaviour
{
    public float backgoubdspeed;
    public Renderer backgroundrenderer;
        // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        backgroundrenderer.material.mainTextureOffset +=new Vector2(backgoubdspeed * Time.deltaTime,0f);
    }
}
