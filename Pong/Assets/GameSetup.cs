using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSetup : MonoBehaviour {
    public Camera MainCamera;
    public BoxCollider2D TopWall;
    public BoxCollider2D ButtonWall;
    public BoxCollider2D LeftWall;
    public BoxCollider2D RightWall;

    public Transform Player01;
    public Transform Player02;
    
	// Use this for initialization
	void Start ()
    {
        TopWall.size = new Vector2(MainCamera.ScreenToWorldPoint(new Vector2(Screen.width * 2f, 0f)).x, 1f);
        TopWall.offset = new Vector2(0f, MainCamera.ScreenToWorldPoint(new Vector2(0f, Screen.height)).y + 0.5f);

        ButtonWall.size = new Vector2(MainCamera.ScreenToWorldPoint(new Vector2(Screen.width * 2f, 0f)).x, 1f);
        ButtonWall.offset = new Vector2(0f, MainCamera.ScreenToWorldPoint(new Vector2(0f, 0f)).y - 0.5f);

        LeftWall.size = new Vector2(1f, MainCamera.ScreenToWorldPoint(new Vector2(0f, Screen.height * 2f)).y);
        LeftWall.offset = new Vector2(MainCamera.ScreenToWorldPoint(new Vector2(0f, 0f)).x - 0.5f, 0f);

        RightWall.size = new Vector2(1f, MainCamera.ScreenToWorldPoint(new Vector2(0f, Screen.height * 2f)).y);
        RightWall.offset = new Vector2(MainCamera.ScreenToWorldPoint(new Vector2(Screen.width, 0f)).x + 0.5f, 0f);

        Vector2 Position01 = new Vector2(
            MainCamera.ScreenToWorldPoint(new Vector3(75f, Screen.height / 2, 0f)).x,
            MainCamera.ScreenToWorldPoint(new Vector3(75f, Screen.height / 2, 0f)).y
        );
        Player01.position = Position01;
        Vector2 Position02 = new Vector2(
            MainCamera.ScreenToWorldPoint(new Vector3(Screen.width - 75f, Screen.height / 2, 0f)).x,
            MainCamera.ScreenToWorldPoint(new Vector3(Screen.width - 75f, Screen.height / 2, 0f)).y
        );
        Player02.position = Position02;
    }
	
	// Update is called once per frame
	void Update ()
    {
    }
}
