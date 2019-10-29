using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymove : MonoBehaviour {
   public Transform start;
    public Transform end;
    public Transform start1;
    public Transform end1;
    public LayerMask detect;
    public LayerMask detect1;
    public bool line;
    public float speed1;
    Transform mytrans;
    Rigidbody2D mybody;
    public GameObject shot;
    
    public GameObject trigger1;
    public GameObject trigger2;
    // Use this for initialization
    void Start () {
        mytrans = this.transform;
        mybody = this.GetComponent<Rigidbody2D>();

    }
	
	// Update is called once per frame
	void Update () {
        Vector2 myvel = mybody.velocity;
        myvel.x = mytrans.right.x*speed1;
        mybody.velocity = myvel;
        line =Physics2D.Linecast(start.position, end.position, detect);
        bool detectplayer = Physics2D.Linecast(start1.position, end1.position, detect1);
        if (line)
        {

            Vector3 currot = mytrans.eulerAngles;
            currot.y += 180;
            mytrans.eulerAngles = currot;
            

        }
        if(detectplayer)
        {
           
            myvel = new Vector2(0,0);
            mybody.velocity = myvel;
            shot.SetActive(true);
            DestroyObject(trigger1);
            DestroyObject(trigger2);
        }
       
      
      
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "playershot")
        { DestroyObject(this.gameObject); }
        if(collision.tag=="Player"&&Input.GetMouseButton(0))
        {
            DestroyObject(gameObject);
        }
    }
   
}
