using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Takegun : MonoBehaviour {
    public GameObject place;
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
            DestroyObject(this.gameObject);
            place.SetActive(true);
        }
    }
}
