using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choices : MonoBehaviour {


    //------------EJ ANVÄND -----------

    public int scenario;
    public List<string> team1 = new List<string>();
    public List<string> team2 = new List<string>();

    // Use this for initialization
    void Start () {

        team1.Add("Wydrin");

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    //Möjliga teams - EJ ANVÄND
    public void teams(int choice)
    {
        switch(choice)
        {
            case 1:
                team1.Add("Sebastian");
                team2.Add("Dallen");
                team2.Add("Nuava");

                scenario = choice;
            break;
            case 2:
                team1.Add("Dallen");
                team2.Add("Sebastian");
                team2.Add("Nuava");

                scenario = choice;
                break;
            case 3:
                team1.Add("Nuava");
                team2.Add("Sebastian");
                team2.Add("Dallen");

                scenario = choice;
                break;
        }

    }

}
