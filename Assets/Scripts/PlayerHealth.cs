using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public int currentHealthPlayer = 1500;
    [SerializeField] GameObject deathFX;
    [SerializeField] Transform parent;
    void Update()
    {
        if (currentHealthPlayer <= 0)
        {
            currentHealthPlayer = currentHealthPlayer - 1;
           
        }
    }
    public void ApplyDamage(int damageToTake)
    {
        Debug.Log(Time.frameCount + ": ApplyDamage was called.");
        currentHealthPlayer -= damageToTake;
        GameObject fx = Instantiate(deathFX, transform.position, Quaternion.identity);
        fx.transform.parent = parent;
     
    }
}