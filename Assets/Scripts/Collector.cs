using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collector : MonoBehaviour
{
    public Text flyText;
    private float flyCollect = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Fly"))
        {
            flyCollect ++;
            flyText.text = flyCollect.ToString();
            Destroy(collision.gameObject);
            
        }
    }   
}
