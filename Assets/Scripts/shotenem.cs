using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotenem : MonoBehaviour {
    public Transform start;
    public Transform end;
    public LayerMask playernotice;
    public GameObject shot;
    void Start () {
		
	}
	
	
	void Update () {
        bool colliding = Physics2D.Linecast(start.position, end.position, playernotice);
        if(colliding)
        {
            shot.SetActive(true);

        }
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "playershot")
        { DestroyObject(this.gameObject); }
    }
}
