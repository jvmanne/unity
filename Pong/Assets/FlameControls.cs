using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameControls : MonoBehaviour {
    public KeyCode MoveUp;
    public KeyCode MoveDown;
    public float speed = 10;

	// Use this for initialization
	void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (Input.GetKey(MoveUp))
        {
            Vector2 velocity = GetComponent<Rigidbody2D>().velocity;
            velocity.y = speed;
            GetComponent<Rigidbody2D>().velocity = velocity;
        }
        else if (Input.GetKey(MoveDown))
        {
            Vector2 velocity = GetComponent<Rigidbody2D>().velocity;
            velocity.y = -speed;
            GetComponent<Rigidbody2D>().velocity = velocity;
        }
        else
        {
            Vector2 velocity = GetComponent<Rigidbody2D>().velocity;
            velocity.y = 0;
            GetComponent<Rigidbody2D>().velocity = velocity;
        }
    }
}
