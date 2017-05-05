using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swordsman : MonoBehaviour
{

    //------------EJ ANVÄND -----------

    int hp = 20;
    int attack = 7;

    void Hurt(int dmg)
    {

        hp = hp - dmg;
    }
}
