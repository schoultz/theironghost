using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wormgenerator : MonoBehaviour
{
    [SerializeField]
    GameObject worm;

    // Use this for initialization
    void Start()
    {
        //Skapar 1o st kloner av orginalmasken som spawnar mellan någonstans mellan (-5 till 5,- 5 till 5)
        for (int i = 0; i < 10; i++)
        {
            int rnd = Random.Range(-5, 5);
            Instantiate(worm, new Vector2(rnd, rnd), Quaternion.identity);
        }

    }
}