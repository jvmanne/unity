using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideWalls : MonoBehaviour {


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name.Equals("ball"))
        {
            GetComponent<AudioSource>().Play();
            GameManager.Score(transform.name);
            collision.gameObject.SendMessage("ResetBall");
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
