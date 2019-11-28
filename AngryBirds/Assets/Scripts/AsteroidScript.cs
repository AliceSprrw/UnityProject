using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidScript : MonoBehaviour
{

    protected Rigidbody2D rb2d;
    protected Vector2 velocity;

    protected Vector3 startPos;
    protected float throwForce = 30f;
    private bool onAsteroid;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D> ();
        onAsteroid = false;
    }

    // Update is called once per frame
    void Update()
    {
        

        if(Input.GetMouseButtonDown(0)){
            startPos = Input.mousePosition;
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if(hit.collider != null ){
                GameObject go = hit.collider.gameObject;
                if(go.name == "Asteroid"){
                    onAsteroid = true;
                 }
            } 
            else{
                onAsteroid = false;
            }
        }
        if(Input.GetMouseButtonUp(0) && onAsteroid == true){
                     rb2d.isKinematic = false;
                     rb2d.angularDrag = 1;
                     Vector3 direction = Input.mousePosition - startPos;
                    rb2d.AddForce(-direction *throwForce);
                }






/*
                if(Input.GetMouseButtonDown(0)){
                     startPos = Input.mousePosition;
                 }
                if(Input.GetMouseButtonUp(0)){
                     rb2d.isKinematic = false;
                     rb2d.angularDrag = 1;
                     Vector3 direction = Input.mousePosition - startPos;
                    rb2d.AddForce(-direction *throwForce);
                }
*/





        
        
    }

}
