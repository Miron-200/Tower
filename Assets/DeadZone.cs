using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        DestroyObject destroyObject = other.GetComponent<DestroyObject>();
        if (destroyObject == null) return;
        destroyObject.DestroyAfter(0.2f);
    }
}
