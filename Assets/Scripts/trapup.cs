using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trapup : MonoBehaviour {
   public Transform start1;
   public Transform end1;
 
   public LayerMask detect;
    Transform thistrans;
    public float speed;
    Rigidbody2D thisbody;
    // Use this for initialization
    void Start () {
        thisbody = GetComponent<Rigidbody2D>();
        thistrans = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 move = thisbody.velocity;
        move.y = thistrans.up.y * speed;
        thisbody.velocity = move;
        bool colliding1 = Physics2D.Linecast(start1.position, end1.position, detect);
        
        if (colliding1)
        {
            Vector3 currot = thistrans.eulerAngles;
            currot.x += 180;
            thistrans.eulerAngles = currot;
        }
       
	}
}
