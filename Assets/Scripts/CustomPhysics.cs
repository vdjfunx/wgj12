﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomPhysics : MonoBehaviour {

    public float decelaration = 0.01f;
    public float grassDecelaration = 1.0f;
    public float maxSpeed = 10.0f;

    private float playerSpeed = 5.0f;

    private float currentDecelaration = 0.0f;

    public void BoostSpeed(float speed)
    {
        if(playerSpeed < maxSpeed && (playerSpeed+speed) > 0.01f)
        { 
            playerSpeed += speed;
        }
    }

    public void SetHighFriction(bool friction)
    {
        if (friction)
        {
            currentDecelaration = grassDecelaration;
        }
        else
        {
            currentDecelaration = decelaration;
        }
    }

    public float Speed()
    {
        return playerSpeed;
    }


    public float MaxSpeed()
    {
        return maxSpeed;
    }


    // Use this for initialization
    void Start () {
        currentDecelaration = decelaration;
    }
	
	// Update is called once per frame
	void Update () {
		
	}



    void FixedUpdate()
    {
        if(playerSpeed > 0.001f)
            playerSpeed -= Time.deltaTime * currentDecelaration;
    }

}
