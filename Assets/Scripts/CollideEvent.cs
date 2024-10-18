using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollideEvent : MonoBehaviour
{
    public UnityEvent collideEvent;
    public string tagCheck;
    public bool selfDestruct;
    public float contactDmg;
    void OnTriggerEnter(Collider _other)
    {
        if(_other.tag == tagCheck)
        {
            if (selfDestruct (true))
            {
                Destroy(gameObject);
            }
        }
    }
}
