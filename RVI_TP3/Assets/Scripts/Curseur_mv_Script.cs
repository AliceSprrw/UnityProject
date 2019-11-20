using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Curseur_mv_Script : MonoBehaviour {
	public Camera camSecondaire;
	public Text text;
	private int nbSphereHorsPlateau;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


		if (Camera.main.ScreenToViewportPoint (Input.mousePosition).x < 1) {
			Vector3 pos = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 13);
			transform.position = Camera.main.ScreenToWorldPoint (pos);

			//Clic sur le curseur  = création d'une sphère avec un collider random 
			if (Input.GetMouseButtonDown (0)) {
				int r = Random.Range (1, 4);
				GameObject s = GameObject.CreatePrimitive (PrimitiveType.Sphere);
				s.tag = "sphere";
				Renderer rend = s.GetComponent<Renderer> ();
				rend.material.mainTexture = Resources.Load<Texture2D> ("Textures/watercol");
				Rigidbody gameObjectsRigidBody = s.AddComponent<Rigidbody>(); // Add the rigidbody.
				//gameObjectsRigidBody.mass = 5; // Set the GO's mass to 5 via the Rigidbody.
				s.transform.position = transform.position;
				if (r == 1) {
					Collider collider = s.GetComponent<Collider>();
					collider.material = Resources.Load<PhysicMaterial> ("PhysMaterials/Phys01");
				}
				if (r == 2) {
					Collider collider = s.GetComponent<Collider>();
					collider.material = Resources.Load<PhysicMaterial> ("PhysMaterials/Phys02");
				}
				if (r == 3) {
					Collider collider = s.GetComponent<Collider>();
					collider.material = Resources.Load<PhysicMaterial> ("PhysMaterials/Phys04");
				}
			}

			

		} 
		else {
			Vector3 pos = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 13);
			transform.position = camSecondaire.ScreenToWorldPoint (pos);


			//Clic sur le curseur  = création d'une sphère avec un collider random 
			if (Input.GetMouseButtonDown (0)) {
				int r = Random.Range (1, 4);
				GameObject s = GameObject.CreatePrimitive (PrimitiveType.Sphere);
				s.tag = "sphere";
				Renderer rend = s.GetComponent<Renderer> ();
				rend.material.mainTexture = Resources.Load<Texture2D> ("Textures/watercol");
				Rigidbody gameObjectsRigidBody = s.AddComponent<Rigidbody>(); // Add the rigidbody.
				s.transform.position = transform.position;
				if (r == 1) {
					Collider collider = s.GetComponent<Collider>();
					collider.material = Resources.Load<PhysicMaterial> ("PhysMaterials/Phys01");
				}
				if (r == 2) {
					Collider collider = s.GetComponent<Collider>();
					collider.material = Resources.Load<PhysicMaterial> ("PhysMaterials/Phys02");
				}
				if (r == 3) {
					Collider collider = s.GetComponent<Collider>();
					collider.material = Resources.Load<PhysicMaterial> ("PhysMaterials/Phys04");
				}
			}



		}

		var spheres = GameObject.FindGameObjectsWithTag("sphere");
		foreach (GameObject s in spheres){
			if (s.transform.position.y < 0 ) {
				nbSphereHorsPlateau++;
				Destroy (s);
			}
		}
		text.text = "Nombre de sphères hors plateau : " + nbSphereHorsPlateau;




	}
		
}
