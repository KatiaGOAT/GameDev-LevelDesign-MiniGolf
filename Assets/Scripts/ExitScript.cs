using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Check if the collision is with a specific object or tag
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("LevelDesign_Scene");
        }
    }
}
