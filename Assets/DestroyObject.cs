using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DestroyObject : MonoBehaviour
{
    [SerializeField] GameObject Object;
    public UnityEvent onDestroyed;
    public void DestroyAfter(float time = 0)
    {
        if (Object != null)
        {
            Destroy(Object, time);
        }
        else
        {
            Destroy(gameObject, time);
        }        
        onDestroyed?.Invoke();        
    }   
}
