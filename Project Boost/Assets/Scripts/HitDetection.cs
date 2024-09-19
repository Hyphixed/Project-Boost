using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HitDetection : MonoBehaviour
{

    void OnCollisionEnter(Collision other)
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        int nextScene = SceneManager.GetActiveScene().buildIndex + 1;
        int allScenes = SceneManager.sceneCountInBuildSettings;



        if (other.gameObject.tag == "Obstacle")
        {
            SceneManager.LoadScene(currentScene);
        }

        if (other.gameObject.tag == "Finish" && nextScene < allScenes)
        {
            SceneManager.LoadScene(nextScene);
            Debug.Log("Finished");
        } else if (other.gameObject.tag == "Finish")
        {
            SceneManager.LoadScene(0);
        }
            
    }
}

