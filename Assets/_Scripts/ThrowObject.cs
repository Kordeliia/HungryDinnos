using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ThrowObject : MonoBehaviour
{
    private bool isMoving;
    public float speed;
    private float timer;
    private Vector3 motionDirection = new Vector3(0,0,1);

    private Rigidbody rb;
    private DinoMovementController dino;
    private FeedSystemController feedSystemController;
    // Start is called before the first frame update
    void Start()
    {
        isMoving = true;
        timer = 0;
        Debug.Log(timer);
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isMoving)
        {
            Vector3 movement = (motionDirection * speed * Time.fixedDeltaTime);
            rb.MovePosition(transform.position + movement);
        }

        if (timer > 0) { timer -= Time.deltaTime; }
        if (timer < 0) { Destroy(gameObject); timer = 0f; dino.ResumeMovement(); }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground") || other.gameObject.CompareTag("Food")) 
        { 
            isMoving = false;
            //rb.transform.position = new Vector3(rb.transform.position.x, 0, rb.transform.position.y);
            Debug.Log("Colision con " +other.gameObject.name); 
        }

        if (other.gameObject.CompareTag("Dino"))
        {
            Debug.Log("Colision con " + other.gameObject.name);
            dino = other.gameObject.GetComponent<DinoMovementController>();
            timer = 3f;
            feedSystemController.FeedDino(gameObject, other.gameObject);
        }
    }
}
