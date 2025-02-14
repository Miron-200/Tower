using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public Transform destination; // Точка, к которой будет двигаться враг
    public float moveSpeed = 3.5f; // Скорость движения
    public float rotationSpeed = 5f; // Скорость поворота

    private NavMeshAgent agent;

    void Start()
    {
        // Получаем компонент NavMeshAgent
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