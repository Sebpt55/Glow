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
            MoveFactorX = Random.Range(minimum, maximum);
            yield return new WaitForSeconds(3);
        }
    }
    IEnumerator NumberGenY()
    {
        while (true)
        {
            MoveFactorY = Random.Range(minimum, maximum);
            yield return new WaitForSeconds(3);
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
    }
}
