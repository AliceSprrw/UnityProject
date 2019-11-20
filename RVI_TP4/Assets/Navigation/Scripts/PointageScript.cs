using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointageScript : MonoBehaviour {
	private bool lockC;
	// Use this for initialization
	void Start () {
		lockC = false;
	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetMouseButtonDown (0)) {
			lockC = true;
			Vector3 pos = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 13);
			Camera cam = this.GetComponent<Camera> ();
			Vector3 screenPos = cam.ScreenToWorldPoint (pos);
			//Vector3 screenPos = Camera.current.WorldToViewportPoint(Input.mousePosition);
			GameObject s = GameObject.CreatePrimitive (PrimitiveType.Sphere);
			s.transform.position = screenPos;
			if (Input.GetMouseButtonDown (0)) {
				lockC = false;
			}

		} 


		if (lockC == false) {
			//Rotation du torse
			float angleR = transform.eulerAngles.x;
			transform.Rotate (-angleR, 0, 0);

			float axeXMouse = Input.GetAxis ("Mouse X");
			transform.Rotate (0, axeXMouse, 0);

			transform.Rotate (angleR, 0, 0);

		}
		

		
		
	}
}
