using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectiles : MonoBehaviour
{
    public Transform playerShip;
    public float range = 20.0f;
    public float enemyGunImpulse = 10.0f;
    bool onRange = false;
    public Rigidbody projectile;
    

   void Start()
    {
        float rand = Random.Range(1.0f, 2.0f);
        InvokeRepeating("Shoot", 2, rand);
      
    }
    void Shoot()
    {
        if (onRange)
        {

            Rigidbody enemyGun = (Rigidbody)Instantiate(projectile, transform.position + transform.forward, transform.rotation);
            enemyGun.AddForce(transform.forward * enemyGunImpulse, ForceMode.Impulse);
        }
    }

    void Update()
    {
        onRange = Vector3.Distance(transform.position, playerShip.position) < range;

        if (onRange)
            transform.LookAt(playerShip);
    }
}




