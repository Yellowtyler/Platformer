using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour {

    public GameObject bullet;
    public float delay;
    public float destroytime;
    public GameObject enemy;
	// Use this for initialization
	void Start () {
        StartCoroutine(shoot());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    IEnumerator shoot()
    {
      while(true)
        {
            yield return new WaitForSeconds(delay);
            GameObject clone = (GameObject)Instantiate(bullet,transform.position, Quaternion.identity);
            DestroyObject(clone, destroytime);
            if (enemy.transform.localScale.x ==-1)
            {
                clone.transform.Rotate(0, 180, 0);
            }
            if (enemy.transform.localScale.x == 1)
            {
                clone.transform.Rotate(0, 0, 0);
            }

        }
    }
}
