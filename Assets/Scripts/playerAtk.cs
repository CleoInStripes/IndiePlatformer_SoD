using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAtk : MonoBehaviour
{
    public float atkEnd = 0.5f; // Time in seconds before the atk ends
    public GameObject atkGameObject;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            atkGameObject.SetActive(true); // Make the atk visible
            Invoke("End", atkEnd); // Delay end
        }
    }

    void End()
    {
        atkGameObject.SetActive(false); // End of atk
    }
}
