using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class movTontaco : MonoBehaviour
{
    public float followDistance = 1000f;
    public float moveSpeed = 5f;

    private Transform player;
    private bool following = false;

    private void Start()
    {
        player = GameObject.FindWithTag("Jugador").transform;
    }

    private void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        if (distanceToPlayer <= followDistance)
        {
            following = true;
            transform.position = Vector3.MoveTowards(transform.position, player.position, moveSpeed * Time.deltaTime);
        }
        else
        {
            following = false;
        }
    }

    private void LateUpdate()
    {
        if (!following)
        {
            transform.position = transform.position;
        }
    }

}
