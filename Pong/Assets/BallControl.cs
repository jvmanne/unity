using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour {
    public float BallSpeed = 100;

	// Use this for initialization
	void Start () {
        StartCoroutine(Delay());
	}

    public void Update()
    {
        Vector2 Vel = GetComponent<Rigidbody2D>().velocity;
        float xVel = Vel.x;
        if (xVel < 18 && xVel > -18 && xVel != 0)
        {
            if (xVel > 0)
            {
                Vel.x = 20;
                GetComponent<Rigidbody2D>().velocity = Vel;
            }
            else
            {
                Vel.x = -20;
                GetComponent<Rigidbody2D>().velocity = Vel;
            }
        }
    }

    void OnCollisionEnter2D (Collision2D ColInfo) {
		if (ColInfo.collider.tag.Equals("Player"))
        {
            Vector2 Vel = GetComponent<Rigidbody2D>().velocity;
            Vel.y = Vel.y / 2 + ColInfo.collider.GetComponent<Rigidbody2D>().velocity.y/3;
            GetComponent<Rigidbody2D>().velocity = Vel;
            GetComponent<AudioSource>().pitch = Random.Range(0.8f, 1.2f);
            GetComponent<AudioSource>().Play();
        }
	}

    public void StartBall()
    {
        var randomStart = Random.Range(0, 2);
        if (randomStart <= 0.5)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(BallSpeed, 10));
        }
        else
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-BallSpeed, -10));
        }
    }

    public void ResetBall()
    {
        Rigidbody2D ball = GetComponent<Rigidbody2D>();
        ball.velocity = new Vector2(0, 0);
        ball.position = new Vector2(0, 0);
        StartCoroutine(Delay());
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds((float)0.5);
        StartBall();
    }
}
