using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // ok as long as this is the only script that loads scenes

public class CollisionHandler : MonoBehaviour
{
    [Tooltip("FX prefab on player")] [SerializeField] GameObject deathFX;

    void OnTriggerEnter(Collider other)
    {
        LandingPad landingPad = other.gameObject.GetComponent<LandingPad>();

        if (landingPad == null)
        {
            StartDeathSequence();
            deathFX.SetActive(true);

        }
        else
        {
            SendMessage("OnPlayerLanding");
        }
    }
    private void StartDeathSequence()
    {
        SendMessage("OnPlayerDeath");
    }
   
    private void OnTriggerExit(Collider other)
    {
        LandingPad landingPad = other.gameObject.GetComponent<LandingPad>();

        if (landingPad != null)
        {
            SendMessage("OnPlayerTakeOff");
        }
    }

    private void OnParticleCollision(GameObject other) {
        Debug.Log(gameObject.name + "hit by " + other.name);
    }
}