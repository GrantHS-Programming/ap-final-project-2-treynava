using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDirection : MonoBehaviour
{
    public GameObject objectToMove;
    public Vector3 moveDirection;
    public float speed = 3.0f;

    void OnTriggerEnter(Collider other)
    {
        objectToMove.transform.position += moveDirection * speed;
    }
}
