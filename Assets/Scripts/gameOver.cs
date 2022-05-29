using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour
{
    public Text pointsText;
    public Collector finalScore;
    public void Setup(int score) {
        gameObject.SetActive(true);
    }

    public void RestartButton() {
        SceneManager.LoadScene("SampleScene");
    }
    public void ExitButton() {
        SceneManager.LoadScene("MainMenu");
    }
}
