using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float MovementSpeed = 2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var movementside = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(movementside, 0, 0) * Time.deltaTime * MovementSpeed;
        var movementup = Input.GetAxis("Vertical");
        transform.position += new Vector3(0, movementup, 0) * Time.deltaTime * MovementSpeed;

    }

  
}
