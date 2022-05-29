using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployBird : MonoBehaviour
{
    public GameObject birdPrefab;
    public float respawnTime = 3.0f;
    private Vector2 screenBounds;
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(birdWave());
    }

    private void spawnEnemy() {
        GameObject a = Instantiate(birdPrefab) as GameObject;
        a.transform.position = new Vector2(5, Random.Range(-1.4f, 1.2f));
    }

    IEnumerator birdWave() {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
            respawnTime = respawnTime - 0.003f;
        }
    }
}
