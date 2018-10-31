﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Sandwich : MonoBehaviour {
    public Vector3 goal;
    public NavMeshAgent agent;
	// Use this for initialization
	void Start () {
        agent = GetComponent<NavMeshAgent>();
        agent.destination = goal;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}