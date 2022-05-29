using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMan : MonoBehaviour
{
    public static bool isGameOver;
    public GameObject GameOverScreen;
    private void Awake()
    {
        isGameOver = false;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
        {
            GameOverScreen.SetActive(true);
        }
    }
}
