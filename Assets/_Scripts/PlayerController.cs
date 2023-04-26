using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class PlayerController : MonoBehaviour
{
    public int speed;
    private Vector3 offset;
    private Rigidbody rbPlayer;
    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        rbPlayer = GetComponent<Rigidbody>();
        offset = new Vector3(0f, 5f, 0f);
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(horizontalInput * speed * Time.fixedDeltaTime, 0f, 0f);
        rbPlayer.MovePosition(transform.position + movement);
    }

    private void Update()
    {
        //Acciones personaje
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            //Si entramos aquí, lanzamos un proyectil.
            Instantiate(projectilePrefab, (transform.position + offset), projectilePrefab.transform.rotation);
        }
    }
}
