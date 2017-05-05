using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour {

    //Scenen ändras till argumentet 
    public void ChangeScene(int changeToScene)
    {
        SceneManager.LoadScene(changeToScene);
    }


}

