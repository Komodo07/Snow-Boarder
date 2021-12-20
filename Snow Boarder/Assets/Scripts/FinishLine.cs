using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float invokeDelay = 2.0f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
           Invoke(nameof(ReloadScene), invokeDelay);
        }
         
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
