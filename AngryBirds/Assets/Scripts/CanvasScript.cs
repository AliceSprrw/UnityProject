using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasScript : MonoBehaviour
{

    public void loadLevelF (){
        SceneManager.LoadScene ("Level1");
    }

    public void loadLevelS (){
        SceneManager.LoadScene ("Level2");
    }


    public void loadMainMenu(){
        SceneManager.LoadScene ("Menu");
    }
}
