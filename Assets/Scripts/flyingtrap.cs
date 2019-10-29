using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyingtrap : MonoBehaviour {
    public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 move = new Vector2(0, speed * Time.deltaTime);
        transform.Translate(-move);
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Player")
        {
            Application.LoadLevel(0);
        }
    }
}
