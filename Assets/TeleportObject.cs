using System;
using UnityEngine;


public class TeleportObject : MonoBehaviour
{

    // �����, ����� �������� ����� ������������ ������
    public Transform start;
    public Transform end;

    // �������� �����������
    public float speed = 2.0f;

    // ����, �����������, �������� �� ������ � �������� �����
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
            // ���������, �������� �� �� �������� �����
            if (rigidbody.position == end.position)
            {
                target = start;
                movingToEnd = false;
            }
        }
        else
        {
            // ���������, �������� �� �� ��������� �����
            if (rigidbody.position == start.position)
            {
                target = end;
                movingToEnd = true;
            }
        }

        rigidbody.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
}
