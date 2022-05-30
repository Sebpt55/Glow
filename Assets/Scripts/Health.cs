using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int health;
    public int numOfHearts;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    public gameOver GameOverScreen;

    

    private void Update()
    {
        if (health > numOfHearts) {
            health = numOfHearts;
        }

        for (int i = 0; i < hearts.Length; i++) {
            if (i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }
            if (i < numOfHearts)
            {
                hearts[i].enabled = true;
            }
            else 
            {
                hearts[i].enabled = false;
            }
        }


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bird"))
        {
             if (health == 1)
            {
                health = 0;
                Destroy(this.gameObject);
                PlayerMan.isGameOver = true;
            }
            else if (health > 0)
            {
                health--;
            }
           
        }
    }
}
