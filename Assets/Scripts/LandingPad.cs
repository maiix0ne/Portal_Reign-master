using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandingPad : MonoBehaviour
{

    private void OnTriggerExit(Collider other)
    {
        PlayerController playerController = other.gameObject.GetComponent<PlayerController>();

        if (playerController)
        {
            gameObject.GetComponent<BoxCollider>().enabled = false;

            Invoke("ActivateLandingPad", 10f);
        }
    }

    private void ActivateLandingPad()
    {
        gameObject.GetComponent<BoxCollider>().enabled = true;
    }
}
