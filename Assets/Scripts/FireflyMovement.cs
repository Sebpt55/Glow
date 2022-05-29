using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireflyMovement : MonoBehaviour
{

    public float MoveFactorX = 0f;
    public float MoveFactorY = 0f;
    public float minimum = -1f;
    public float maximum = 1f;
    public float MovementSpeed = 0.2f;

    IEnumerator NumberGenX()
    {
        while (true)
        {
            MoveFactorX = Random.Range(minimum, 0);
            yield return new WaitForSeconds(1);
        }
    }
    IEnumerator NumberGenY()
    {
        while (true)
        {
            MoveFactorY = Random.Range(-0.1f, 0.1f);
            yield return new WaitForSeconds(4f);
        }
    }

    void Start()
    {
        StartCoroutine(NumberGenX());
        StartCoroutine(NumberGenY());
    }

    void Update()
    {
        
        transform.position += new Vector3(MoveFactorX, 0, 0) * Time.deltaTime * MovementSpeed;
        transform.position += new Vector3(0, MoveFactorY, 0) * Time.deltaTime * MovementSpeed;

        if (transform.position.x < -5)
        {
            Destroy(this.gameObject);
        }


    }
}
