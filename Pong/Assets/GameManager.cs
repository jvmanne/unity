using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public static int PlayerScore01 = 0;
    public static int PlayerScore02 = 0;
    public GUISkin ScoreSkin;
    public Transform Ball;

    // Use this for initialization
    void Start()
    {
        Ball = GameObject.FindGameObjectWithTag("ball").transform;
    }

    public static void Score (string WallName)
    {
        if (WallName.Equals("RightWall"))
        {
            PlayerScore01 += 1;
        }
        else
        {
            PlayerScore02 += 1;
        }
    }

    public void OnGUI()
    {
        GUI.skin = ScoreSkin;
        GUI.Label(new Rect(Screen.width / 2 - 150 - 18, 20, 100, 100), "" + PlayerScore01);
        GUI.Label(new Rect(Screen.width / 2 + 150 - 18, 20, 100, 100), "" + PlayerScore02);

        if (GUI.Button(new Rect(Screen.width/2 - 121/2, 10, 121, 53), "RESET"))
        {
            PlayerScore01 = 0;
            PlayerScore02 = 0;
            Ball.SendMessage("ResetBall");
        }
    }
}
