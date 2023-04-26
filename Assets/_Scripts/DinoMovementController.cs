using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoMovementController : MonoBehaviour
{
    public float speed = 10f;
    private bool isMoving;
    private float motionZ = -1; // Elegimos el recorrido que hará el objeto sobre el eje Z. 1 Hacia delante -1 hacía atras.

    private Rigidbody rb;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        isMoving = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(isMoving)
        {
            Vector3 movement = new Vector3(0f, 0f, motionZ * speed * Time.fixedDeltaTime);
            rb.MovePosition(transform.position + movement);
        }
    }

    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.CompareTag("Food"))
        {
            animator.SetBool(EatAnimatorName(gameObject), true);
            isMoving = false;
        }
    }

    private string EatAnimatorName(GameObject dinoName)
    {
        string name = dinoName.name + "_eat";
        return name;
    }

    public void ResumeMovement()
    {
        Debug.Log("Salimos de la colision de la comida");
        animator.SetBool(EatAnimatorName(gameObject), false);
        isMoving = true;
    }
}
