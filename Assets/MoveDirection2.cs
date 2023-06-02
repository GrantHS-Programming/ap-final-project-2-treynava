using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDirection2 : MonoBehaviour
{
    public float speed = 1f;
    public float smoothTime = 0.5f;
    public Vector3 target = new Vector3(10, 4, 20);
    Vector3 currentVelocity;

    private void Update()
    {
        //objectToMove.transform.Translate(moveDirection * speed);
        transform.position = Vector3.SmoothDamp(transform.position, target, ref currentVelocity, smoothTime);
    }
}
