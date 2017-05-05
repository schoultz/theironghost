using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Noobie : MonoBehaviour {


    //------------EJ ANVÄND -----------

    int hp = 15;
    public int attack = 5;

    void Hurt(int dmg)
    {

        hp = hp - dmg;
    }
 
}
