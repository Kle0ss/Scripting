using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform teleportPoint;
    // eto ne start
    void OnTriggerEnter(Collider other)
    {
        //prisvoit the position
        other.transform.position = teleportPoint.position;
    }
}