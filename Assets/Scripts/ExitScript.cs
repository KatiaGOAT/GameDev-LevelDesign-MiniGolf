using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered the ontrigger event");

        // Check if the collision is with a specific object or tag
        if (other.CompareTag("Player"))
        {
            Debug.Log("Changing the scene now");
            SceneManager.LoadScene("LevelDesign_Scene");
        }
    }
}
