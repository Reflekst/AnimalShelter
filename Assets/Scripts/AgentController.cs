using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentController : MonoBehaviour
{
    private Rigidbody rb;
    Vector3 moveDirection;

    private void OnTriggerEnter(Collider other)
    {
        ChangeDestination();
    }
    private void OnTriggerStay(Collider other)
    {
        ChangeDestination();
    }

    private void Start()
    {
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
        moveDirection = new Vector3(Random.Range(-20.5f, 20.5f), 0, Random.Range(-9.5f, 9.5f));
        moveDirection = transform.TransformDirection(moveDirection);
    }
}
