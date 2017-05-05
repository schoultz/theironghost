using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cameracontrol : MonoBehaviour
{


    //------------EJ ANVÄND -----------

    // player
    public Transform playerToFollow;

    // väggar
    public Transform Firstwall;
    public Transform Lastwall;

    //Kamera värden
    public float Height;
    public float Zoom;
    public float maxY;
    public float minY;
    public float maxX;
    public float minX;

    PlayerController pc = new PlayerController();
    public float playerPosY;
    public float playerPosX;

    //!!!!!!!!!!!
    Scene currentScene;


    void Start()
    {
        minX = -3.5f;
        minY = -6.4f;
        maxX = 16.5f;
        maxY = 13.6f;
        playerPosY = pc.playerPosition.y;
        playerPosX = pc.playerPosition.x;

        //currentScene = Application.loadedLevel();
      
    }

    void Update()
    {
        //Om playern vill att kameran ska följa med utanför området så gör den inte det
        //if )
       // transform.position = new Vector2(playerPosX, playerPosY);
       
        
    }

    //UNITY ANSWERS
    IEnumerator FreezeCam()
    {
        //yield return null;
        Camera.main.clearFlags = CameraClearFlags.Nothing;
        yield return null;
        Camera.main.cullingMask = 0;
    }

  
}
