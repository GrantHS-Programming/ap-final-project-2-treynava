using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunScriptOnTrigger2 : MonoBehaviour
{
    public GameObject RunScript;

    void OnTriggerEnter(Collider other)
    {
        RunScript.GetComponent<MoveDirection2>().enabled = true;
    }
}
