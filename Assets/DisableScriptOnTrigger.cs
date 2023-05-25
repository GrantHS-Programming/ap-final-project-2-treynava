using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableScriptOnTrigger : MonoBehaviour
{
    public GameObject RunScript;

    void OnTriggerEnter(Collider other)
    {
        RunScript.GetComponent<MoveDirection>().enabled = false;
    }
}