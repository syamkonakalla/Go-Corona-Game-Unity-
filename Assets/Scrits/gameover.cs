using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour
{
    public GameObject gameoverpanel;
    
    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Player")== null)
        {
            gameoverpanel.SetActive(true);
        }
        
    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    } 
}
