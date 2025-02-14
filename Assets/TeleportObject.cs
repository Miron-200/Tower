using System;
using UnityEngine;


public class TeleportObject : MonoBehaviour
{

    // Точки, между которыми будет перемещаться объект
    public Transform start;
    public Transform end;

    // Скорость перемещения
    public float speed = 2.0f;

    // Флаг, указывающий, движется ли объект к конечной точке
    private bool movingToEnd = true;
    private Transform target;
    private Rigidbody rigidbody;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        target = end;
    }

    void Update()
    {
        if (movingToEnd)
        { 
            // Проверяем, достигли ли мы конечной точки
            if (rigidbody.position == end.position)
            {
                target = start;
                movingToEnd = false;
            }
        }
        else
        {
            // Проверяем, достигли ли мы начальной точки
            if (rigidbody.position == start.position)
            {
                target = end;
                movingToEnd = true;
            }
        }

        rigidbody.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
}
