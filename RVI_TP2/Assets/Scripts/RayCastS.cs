using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RayCastS : MonoBehaviour {
	public Text posCam;
	public Vector3 screenSpace;
	private GameObject target;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//if (Input.GetMouseButtonDown (0)) {

			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit, 100)) {
				target = hit.collider.gameObject;


				if (target != null) {
					posCam.text = target.name + " " + target.transform.position.ToString ();
					screenSpace = Camera.main.WorldToScreenPoint (target.transform.position);
					if (target.name == "Cube") {
						target.transform.position = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, screenSpace.z));
						if (Input.GetAxis("Mouse ScrollWheel") > 0f ){ // forward
							target.transform.Translate (Vector3.forward * Time.deltaTime);
						}
						
						else if (Input.GetAxis("Mouse ScrollWheel") < 0f ) {// backwards
							target.transform.Translate (Vector3.back * Time.deltaTime);
						}	


					}

					
				} 
			}
			

		

			

	}


}
