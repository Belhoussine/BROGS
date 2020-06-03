//<<<<<<< HEAD
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MovementAI : MonoBehaviour
{
    NavMeshAgent agent;
    Transform player;
    Rigidbody rb;

    public GameObject[] waypoints;
    public float speed;
    public bool moving;
    int numOfWaypoints;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GetComponent<Transform>();
        rb = GetComponent<Rigidbody>();

        waypoints = GameObject.FindGameObjectsWithTag("waypoint");

        speed = 4f;
        numOfWaypoints = waypoints.Length-1;
        agent.updatePosition = true;
        agent.updateRotation = true;
        agent.speed = speed;
        
        StartCoroutine("FSM");
    }
    IEnumerator FSM(){
        
        while(true){
            if(agent.velocity.magnitude == 0){
                move(generateIndex());
            }
            yield return new WaitForSeconds(2);
        }     
    }
    void move(int i){
        Debug.Log(i);
        agent.SetDestination(waypoints[i].transform.position);
		Vector3 direction = (waypoints[i].transform.position - transform.position).normalized;
		Quaternion lookRotation = Quaternion.LookRotation(direction);
	}

    int generateIndex(){
        return Random.Range(0, numOfWaypoints);
    }
}
/*
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MovementAI : MonoBehaviour
{
    NavMeshAgent agent;
    Transform player;
    Rigidbody rb;

    public GameObject[] waypoints;
    public float speed;
    public bool moving;
    int numOfWaypoints;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GetComponent<Transform>();
        rb = GetComponent<Rigidbody>();

        waypoints = GameObject.FindGameObjectsWithTag("waypoint");

        speed = 4f;
        numOfWaypoints = waypoints.Length-1;
        agent.updatePosition = true;
        agent.updateRotation = true;
        agent.speed = speed;
        
        StartCoroutine("FSM");
    }
    IEnumerator FSM(){
        
        while(true){
            if(agent.velocity.magnitude == 0){
                move(generateIndex());
            }
            yield return new WaitForSeconds(2);
        }     
    }
    void move(int i){
        agent.SetDestination(waypoints[i].transform.position);
		Vector3 direction = (waypoints[i].transform.position - transform.position).normalized;
		Quaternion lookRotation = Quaternion.LookRotation(direction);
	}

    int generateIndex(){
        return Random.Range(0, numOfWaypoints);
    }
}
//>>>>>>> da27ec4b94a882b33643e1246ba9d76fe3f8733f
*/