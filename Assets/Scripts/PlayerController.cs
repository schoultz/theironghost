using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

    float speed = (float)0.4;
    public Vector3 playerPosition;

    public float xPos;
    public float yPos;


    //Vilken scen det är
    public int sceneNum;
    //---------------------

    [SerializeField]
    GameObject ohText;

    [SerializeField]
    GameObject tutorialText;

    //Tidsverktyg
    private float currentTime;
    private float collisionTime;
    private float timeToShow;
    private Vector2 targetPosition;
    //--------------------------
    

    void Start ()
    {
        //Temporär referens till den nuvarande scenen
        Scene thisScene = SceneManager.GetActiveScene();
        //Vilket nummer scenen är i build index innuti Unity
        sceneNum = thisScene.buildIndex;

        //-------Hur många sekunder OH NO-texten ska visas-----
        timeToShow = 2f;
        ohText.SetActive(false);
        
    }    
    // Update is called once per frame
    void Update()
    {
        moveMe();
        textTimer();
    }

    private void moveMe()
    {
        playerPosition = transform.position;

        xPos = playerPosition.x;
        yPos = playerPosition.y;

        var moveX = Input.GetAxis("Horizontal");
        var moveY = Input.GetAxis("Vertical");

        Vector3 playerMovement = new Vector3(moveX, moveY, 0) * speed;
        playerHitWall(playerPosition + playerMovement);
        Debug.Log(playerMovement);
    
        transform.Translate(playerMovement);
       

        //-------------------------KVAR FÖR FRAMTIDA OPTIMERING-----------------------------
        //Om man går genom sjön så ska man få en bonusnivå
        //if (sceneNum == 1 && yPos < maxWorldY)
        {
          //  SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        //----------------------------------------------------------------------------------
    }


    void OnTriggerEnter2D(Collider2D coll)
    {
        //Om man stöter på enemy så byter den scen, men väntar 2 sek (timeToShow)
        if (coll.gameObject.tag == "enemy")
        {
            //Tiden då kollisionen skedde
            collisionTime = Time.time;  

        }
    }

    void textTimer()
    {
        //Den tiden som konstant uppdateras genom Update
        currentTime = Time.time;

        //Om kollisionen har skett så
        if (collisionTime != 0)
        {
            //När det har gått två sekunder
            if(currentTime - collisionTime > timeToShow)
            {
                collisionTime = 0.0f;
                ohText.SetActive(false);
                SceneManager.LoadScene(3);
            }
            //Innan det gått två sekunder men är precis efter kollisionen
            else
            {
                ohText.SetActive(true);
            }
        }

    }

    //Returnerar sant om spelaren träffar en 2D collider
    bool playerHitWall(Vector3 target)
    {
        //Kollar om playern kolliderar med något då den flyttar sig
        RaycastHit2D blockedBy = Physics2D.Linecast(playerPosition + target, playerPosition);
        //Har playern blivit träffad av något eller ej
        return (blockedBy.collider == GetComponent<Collider2D>());
    }
}
