using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployFly : MonoBehaviour
{
    public GameObject flyPrefab;
    public float respawnTime = 1.0f;
  
    void Start()
    {
        StartCoroutine(flyWave());
    }

    private void spawnFly() {
        GameObject b = Instantiate(flyPrefab) as GameObject;
        b.transform.position = new Vector2(5, Random.Range(-1.5f, 1.5f));
    }

    IEnumerator flyWave() {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnFly();
        }
    }
}
