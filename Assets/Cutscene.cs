using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutscene : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject cutsceneCam;

    void Start()
    {
        cutsceneCam.SetActive(false);
    }

    void OnTriggerEnter(Collider Other)
    {
        cutsceneCam.SetActive(true);
        thePlayer.SetActive(false);
    }
}
