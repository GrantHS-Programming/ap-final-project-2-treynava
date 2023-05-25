using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject Trigger;
    // Start is called before the first frame update
    void Start()
    {
        Trigger.SetActive(false);
    }
    void OnTriggerEnter()
    {
        Trigger.SetActive(true);
    }
    void OnTriggerExit()
    {
        Trigger.SetActive(false);
    }
}
