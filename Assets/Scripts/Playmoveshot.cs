using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playmoveshot : MonoBehaviour {
    public float speed;
    
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 move = new Vector2(speed * Time.deltaTime, 0);
        transform.Translate(move);
       
    }

    
}
