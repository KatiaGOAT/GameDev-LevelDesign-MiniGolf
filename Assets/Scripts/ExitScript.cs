using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with a specific object or tag
        if (collision.gameObject.CompareTag("ExitCollider"))
        {
            SceneManager.LoadScene("LevelDesign_Scene");
        }
    }
}
