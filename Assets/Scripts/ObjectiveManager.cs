using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ObjectiveManager : MonoBehaviour
{
    public static ObjectiveManager instance;
    public int enemyCount;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            if (gameObject == null)
            {
                Destroy(this);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
