﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private object gameManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null)
        {
            other.GetComponent<PlayerController>().speed = 0;
            gameObject.GetComponent<MoveForward>().speed = 0;
            gameManager.GameOver();
        }
        
        else
        {
            Destroy(gameObject);
        }

    }
}
