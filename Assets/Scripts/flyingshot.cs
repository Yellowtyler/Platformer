using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyingshot : MonoBehaviour {
    public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 move = new Vector2(speed * Time.deltaTime, 0);
        transform.Translate(-move);

	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Player")
        {
            Application.LoadLevel("1");
        }
    }
}
