using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentController : MonoBehaviour
{
    public AgentDataScript agentData, clone;
    private Rigidbody rb;
    private Vector3 moveDirection;
    public int health;

    private void Start()
    {
        clone = Object.Instantiate(agentData);
        rb = this.GetComponentInChildren<Rigidbody>();
        ChangeDestination();
    }
    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        rb.MovePosition(transform.position + moveDirection * Time.deltaTime * 0.5f);
    }
    private void ChangeDestination()
    {
        moveDirection = new Vector3(Random.Range(-5, 5), 0, Random.Range(-5, 5));
        moveDirection = transform.TransformDirection(moveDirection);
    }
    private void OnTriggerEnter(Collider other)
    {
        ChangeDestination();
        if (other.CompareTag("AgentTag"))
        {
            clone.TakeDamage();
            if (clone.CheckLifestate)
            {
                Destroy(gameObject);
                SpawnAgent.OneLess();
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        ChangeDestination();
    }
}
