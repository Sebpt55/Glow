using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collector : MonoBehaviour
{
    public Text flyText;
    public Text FinalText;
    public float flyCollect = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Fly"))
        {
            flyCollect ++;
            flyText.text = flyCollect.ToString();
            FinalText.text = flyCollect.ToString();
            Destroy(collision.gameObject);
            
        }
    }   
}
