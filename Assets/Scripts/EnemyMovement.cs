﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour {

    Transform player;
    NavMeshAgent nav;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        nav = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (nav)
        {
            MoveToLocation(player.position);
        }
    }

    public void MoveToLocation(Vector3 targetPoint)
    {
        nav.destination = targetPoint;
        nav.isStopped = false;
    }
}
