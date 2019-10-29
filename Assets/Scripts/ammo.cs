using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammo : MonoBehaviour {
    
    // Use this for initialization
    void Start () {
        playershoot ammo = GetComponent<playershoot>();
    }
	
	// Update is called once per frame
	void Update () {
      
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Player")
        {
            Debug.Log("[EQ");

            
            GameObject.Find("shot").GetComponent<playershoot>().ammo+=6;




            DestroyObject(gameObject);


        }
    }
}
