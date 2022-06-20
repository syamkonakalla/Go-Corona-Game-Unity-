using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spanobstacles : MonoBehaviour
{
    public GameObject obstacles;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float timebetween;
    private float spawnTime;

    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
        if(Time.time > spawnTime)
        {
            Spawn();
            spawnTime=Time.time + timebetween;
        }
        
    }
    void Spawn(){
        float randomX = Random.Range(minX,maxX);
        float randomY = Random.Range(minY,maxY);

        Instantiate(obstacles,transform.position + new Vector3(randomX,randomY,0),transform.rotation);
    }
}