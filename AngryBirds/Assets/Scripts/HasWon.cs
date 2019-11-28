using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HasWon : MonoBehaviour
{
    public Text winText;
    private int nbEnemiesKilled;
    public GameObject[] enemies;
    // Start is called before the first frame update
    void Start()
    {
        nbEnemiesKilled = 0;
        enemies = GameObject.FindGameObjectsWithTag("enemy");
    }

    // Update is called once per frame
    void Update()
    {
        nbEnemiesKilled = 0;
        foreach (GameObject e in enemies)
        {
            SpriteRenderer sp = e.GetComponent<SpriteRenderer>();
            bool isEnabled = sp.enabled;
            if(isEnabled == false){
                nbEnemiesKilled++;
            }
        }
        if(nbEnemiesKilled == enemies.Length){
            winText.text = "Congratulations ! Level completed";
        }
    }
}
