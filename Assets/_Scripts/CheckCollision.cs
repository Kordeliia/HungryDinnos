using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollision : MonoBehaviour
{

    //Es un evento, esto quiere decir que se invocará automaticamente cada vez que un objeto físico entre dentro del trigger del GameObject que contiene este script.
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject); //Destruye el objeto que contiene este script, en este caso la comida :3
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
