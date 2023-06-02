using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFacingBillboard : MonoBehaviour
{
    public Camera m_Camera;

    void Update()
    {
        transform.LookAt(transform.position + m_Camera.transform.rotation * Vector3.forward,
            m_Camera.transform.rotation * Vector3.up);
        Vector3 eulerAngles = transform.eulerAngles;
        eulerAngles.z = 0;
        transform.eulerAngles = eulerAngles;
    }
}