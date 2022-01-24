using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMovement : MonoBehaviour
{
    private int Range = 9;
    private int speed = 3;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        BoundMovement();
    }
    void Movement()
    {
        if (transform.CompareTag("Van"))
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        if (transform.CompareTag("Train"))
            transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
    void BoundMovement()
    {
        if (transform.CompareTag("Train"))
            if (transform.position.x < -Range)
                Destroy(gameObject);
        if (transform.CompareTag("Van"))
            if (transform.position.x > Range)
                Destroy(gameObject);
    }
     
}
