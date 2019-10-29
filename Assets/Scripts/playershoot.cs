using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playershoot : MonoBehaviour {

    public GameObject shot;
    public GameObject noammo;
    public float time;
    public float ammo;
    public float maxammo = 6;
    
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (ammo > maxammo)
        {
            ammo = 6;
        }
        if (Input.GetMouseButtonDown(0))
        {

            
            
                GameObject clone;

               
            
            
            if(ammo<=0)
            {
                 clone = (GameObject)Instantiate(noammo, transform.position, Quaternion.identity);
                DestroyObject(clone, time);
            }
            if(ammo>0)
            {
                clone = (GameObject)Instantiate(shot, transform.position, Quaternion.identity);

                if (GameObject.Find("Player").transform.localScale.x == -1)
                {
                    clone.transform.Rotate(0, 180, 0);
                }
                ammo--;
                DestroyObject(clone, time);
            }
            
        }

       
	}
}
