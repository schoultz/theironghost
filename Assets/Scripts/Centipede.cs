using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Centipede : MonoBehaviour {

    int hp = 20;
    int attack = 3;

    //float speed = 0.2f;

    public Vector3 centipedePos;

    [SerializeField]
    public float delta;  // Amount to move left and right from the start point
    [SerializeField]
    public float speed;
    private Vector3 startPos;


    Vector3 movement;
    void Start ()
    {
        startPos = transform.position;
    }

    void Update()
    {

        transform.position = moveAlgorithm();
    }

    void Hurt (int dmg) {

        hp = hp - dmg;
	}
	
    Vector3 moveAlgorithm()
    {
        Vector3 v = startPos;
        v.x += delta * Mathf.Sin(Time.time * speed);
        return v;
    }
}
