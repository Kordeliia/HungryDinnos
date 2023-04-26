using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform target; // Referencia al objeto que queremos seguir
    public Vector3 offset; // Desplazamiento de la cámara con respecto al personaje
    public float followLimit;
    private const string MAIN_GROUND = "MainGround";

    private void Start()
    {
        followLimit = (GameObject.Find(MAIN_GROUND).GetComponent<BoxCollider>().size.x) / 0.4f;
        Debug.Log(followLimit);
    }

    void LateUpdate()
    {

        if (target.position.x < followLimit && target.position.x > -followLimit)
        {
            transform.position = target.position + offset;
        }
    }
}
