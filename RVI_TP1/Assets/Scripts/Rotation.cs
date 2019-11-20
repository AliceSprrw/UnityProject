using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {

	public float speed;
	float y;
	// Use this for initialization
	void Start () {
		Debug.Log(gameObject.name);

	}
	
	// Update is called once per frame
	void Update () {
		y += Time.deltaTime * speed;
		transform.rotation = Quaternion.Euler(0,y,0);
	}
}
