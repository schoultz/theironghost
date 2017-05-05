using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour {

    //Storleken på den osynliga avkännaren som signalerar att börja att attackera
    [SerializeField]
    float rangeField;

    //Hur snabbt fienden rör sig frammåt
    public float speed = 3;
    public float enemySpeed;

    float xPlayer;
    float yPlayer;
    float xAttackRange;
    float yAttackrange;

    float xEnemy;
    float yEnemy;

    Vector3 posPlayer;

    void Start () {

        //Enemys position i x- och y-led
        xEnemy = transform.position.x;
        yEnemy = transform.position.y;

        //Det osynliga fältet sätts runt fienden
        xAttackRange = xEnemy + rangeField;
        yAttackrange = yEnemy + rangeField;
	}

	void Update () {        
        //Kollar Playerns position och om det är dags att attackera
        PlayerPos();
        AttackChecker();
	}

    public void PlayerPos()
    {
        //Hitta playerobjektet
        GameObject player = GameObject.Find("Player");

        PlayerController playercontroller = player.GetComponent<PlayerController>();
        //Playerns x- och y-position
        xPlayer = playercontroller.xPos;
        yPlayer = playercontroller.yPos;

        posPlayer = playercontroller.playerPosition;
        
    }

    void AttackChecker()
    {
        //Avståndet mellan playern och fienden - det osynliga fältet
        float xDistanceToPlayer = Mathf.Abs(xPlayer - xEnemy);
        float yDistanceToPlayer = Mathf.Abs(yPlayer - yEnemy);

        //Om Playern kommer innanför rangen så attackeras den
        if (xDistanceToPlayer <= rangeField && yDistanceToPlayer <= rangeField)
        {
            enemySpeed = (float)speed * Time.deltaTime;
            Debug.Log("AHH DON'T TOUCH ME");

            transform.position = Vector3.MoveTowards(transform.position, posPlayer, enemySpeed);


        }      
    }

}
