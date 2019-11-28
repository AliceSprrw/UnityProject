using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HitEnemy : MonoBehaviour
{
    protected SpriteRenderer sp;
    protected Collider2D col2d;


    void Start(){
        sp = GetComponent<SpriteRenderer>();
        col2d = GetComponent<Collider2D>();
    }

    void OnCollisionEnter2D(Collision2D col){
        sp.enabled = false;
        col2d.enabled = false;
    }

}
