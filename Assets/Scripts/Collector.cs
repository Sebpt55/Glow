using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collector : MonoBehaviour
{

    public AudioSource audioPlayer;

    public Text flyText;
    private float flyCollect = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Fly"))
        {
            audioPlayer.Play();
            flyCollect ++;
            flyText.text = flyCollect.ToString();
            Destroy(collision.gameObject);
            
        }
    }   
}
