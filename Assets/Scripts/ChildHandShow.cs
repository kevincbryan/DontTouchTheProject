using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildHandShow : MonoBehaviour
{

    public GameObject HandArea;
    public GameObject HandParticles;

private void OnTriggerEnter(Collider other) 
{
    if (other.tag == "BiteZone")
    {
        HandArea.SetActive(true);
        HandParticles.SetActive(true);
        Invoke("HandsOff", 5f);

    }
}

void HandsOff()
{
    HandArea.SetActive(false);
    HandParticles.SetActive(false);
}

}
