using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField] GameObject deathFX;
    [SerializeField] Transform parent;
    [SerializeField] int scorePerHit = 100;
    [SerializeField] int hits = 6;


    private GameController gameController;

    void Start()

    {
        AddBoxCollider();
        gameController = FindObjectOfType<GameController>();
    }
    private void AddBoxCollider()
    {
        Collider boxCollider = gameObject.AddComponent<BoxCollider>();
        boxCollider.isTrigger = false;
    }

    void OnParticleCollision(GameObject other)
    {

        Debug.Log(gameObject.name + " hit by " + other.name);

        ProcessHit();
        if (hits <= 1 && gameObject.activeSelf)
        {
            KillEnemy();
        }
    }

    private void ProcessHit()
    {
        gameController.AddScore(scorePerHit);
        hits = hits - 1;
        // todo consider hit FX
    }
    private void KillEnemy()
    {
        GameObject fx = Instantiate(deathFX, transform.position, Quaternion.identity);
        fx.transform.parent = parent;

        gameObject.SetActive(false);

        gameController.DecreaseEnemyCount();

        Destroy(gameObject);
    }
}


