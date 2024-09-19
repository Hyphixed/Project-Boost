using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HitDetection : MonoBehaviour
{  
    
    
    void OnCollisionEnter(Collision other) 
    {        
        if (other.gameObject.tag == "Obstacle")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (other.gameObject.tag == "Finish")
        {
            int nextScene = SceneManager.GetActiveScene().buildIndex + 1;
            SceneManager.LoadScene(nextScene);
            Debug.Log("Finished");
        }
    }
}
