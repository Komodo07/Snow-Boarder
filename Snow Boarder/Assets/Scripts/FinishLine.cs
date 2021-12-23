using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float invokeDelay = 2.0f;
    [SerializeField] ParticleSystem finishedEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            finishedEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke(nameof(ReloadScene), invokeDelay);
        }
         
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
