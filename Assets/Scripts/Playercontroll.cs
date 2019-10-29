using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroll : MonoBehaviour {
  public float speed;
    
	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey("a"))
        {

            transform.Translate((-transform.right) * speed * Time.deltaTime);
            transform.localScale = new Vector3(-1, 1, 1);
        }
        if (Input.GetKey("d"))
        {

            transform.Translate(transform.right * speed * Time.deltaTime);
            
            transform.localScale = new Vector3(1, 1, 1);
        }
        if (Input.GetKey("w"))
        {

            transform.Translate(transform.up * speed * Time.deltaTime);
        }
        
       


    }
   
}
