using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private int speed = 5;
    private float Range = 9;
    public bool GameOver = false;
   
    private void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        ControlPlayer();
    }

    void ControlPlayer()
    {
        Movement(speed);
        BoundMovement(Range);
    }
    void Movement(int speed)
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
    }
    void BoundMovement(float xRange)
    {
        if (transform.position.x > Range)
            transform.position = new Vector3(Range, transform.position.y, transform.position.z);
        if (transform.position.x < -Range)
            transform.position = new Vector3(-Range, transform.position.y, transform.position.z);
        if (transform.position.z > Range)
            transform.position = new Vector3(transform.position.x, transform.position.y, Range);
        if (transform.position.z < -Range)
            transform.position = new Vector3(transform.position.x, transform.position.y, -Range);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Train") || collision.gameObject.CompareTag("Van"))
        {
            Destroy(gameObject);
            GameOver = true;
        }
       
    }
}
