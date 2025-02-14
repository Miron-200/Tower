using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public Transform destination; // �����, � ������� ����� ��������� ����
    public float moveSpeed = 3.5f; // �������� ��������
    public float rotationSpeed = 5f; // �������� ��������

    private NavMeshAgent agent;

    void Start()
    {
        // �������� ��������� NavMeshAgent
        agent = GetComponent<NavMeshAgent>();
        if (agent != null)
        {
            agent.speed = moveSpeed;
        }

        if (destination == null)
        {
            Debug.LogError("Destination is not set for the enemy.");
        }

        agent.SetDestination(destination.position);
    }   
}