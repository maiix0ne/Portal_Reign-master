using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManagement : MonoBehaviour
{
    // The target marker.
    [SerializeField] Transform target;

    // Angular speed in radians per sec.
    [SerializeField] float speed;

    // Start is called before the first frame update
    void Start()
    {
        AddSphereCollider();
    }

    private void AddSphereCollider()
    {
        Collider sphereCollider = gameObject.AddComponent<SphereCollider>();
        sphereCollider.isTrigger = false;
    }

    void Update()
    {
        Vector3 targetDir = target.position - transform.position;

        // The step size is equal to speed times frame time.
        float step = speed * Time.deltaTime;

        Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, step, 0.0f);
        Debug.DrawRay(transform.position, newDir, Color.red);

        // Move our position a step closer to the target.
        transform.rotation = Quaternion.LookRotation(newDir);
    }
}




