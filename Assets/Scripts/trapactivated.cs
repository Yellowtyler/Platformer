﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trapactivated : MonoBehaviour {
    public GameObject trap;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Player")
        {
           trap.SetActive(true);
        }
    }
}
