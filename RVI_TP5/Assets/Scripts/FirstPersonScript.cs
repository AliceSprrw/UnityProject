using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonScript : MonoBehaviour {
	private bool lockCam = false;
	private bool modeNav = true;
	private GameObject curseur;
	Vector3 posdebut;
	Vector3 posFin;
	// Use this for initialization
	void Start () {
		curseur = GameObject.CreatePrimitive (PrimitiveType.Sphere);
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0)){
			if (modeNav == false) {
				modeNav = true;
			} else {
				modeNav = false;
			}

		}
		curseur.transform.position = Camera.main.ScreenToWorldPoint (new Vector3(Input.mousePosition.x, Input.mousePosition.y, 13));
		if (modeNav == true) {
			//Mode Navigation
			// Si Objet devant --> on ne peut pas avancer
			if (Physics.Raycast (transform.position, transform.TransformDirection (Vector3.forward), 1)) {
				Debug.Log ("There is something in front of the object!");

				//Pas à gauche
				if (Input.GetKey (KeyCode.Q)) {
					transform.Translate (new Vector3 (-30.0f * Time.deltaTime, 0, 0));
				}
				//Pas à droite 
				if (Input.GetKey (KeyCode.D)) {
					transform.Translate (new Vector3 (30.0f * Time.deltaTime, 0, 0));
				}


				//Rotation du torse
				float angleR = transform.eulerAngles.x;
				transform.Rotate (-angleR, 0, 0);

				float axeXMouse = Input.GetAxis ("Mouse X");
				transform.Rotate (0, axeXMouse, 0);

				transform.Rotate (angleR, 0, 0);



				//Lock du curseur souris
				if (Input.GetKeyDown (KeyCode.I)) {
					if (Cursor.lockState == CursorLockMode.Locked) {
						Cursor.lockState = CursorLockMode.None;
					} else {
						Cursor.lockState = CursorLockMode.Locked;
					}
				}

				//Lever la tête
				float axeYMouse = Input.GetAxis ("Mouse Y");
				//Debug.Log(axeYMouse);
				transform.Rotate (-axeYMouse, 0, 0);



				//Saut 
				if (Input.GetKeyDown (KeyCode.Space)) {
					StartCoroutine ("Jump");
				}


				//Lean  --> rotation de la tête
				//Pencher à gauche
				if (Input.GetKey (KeyCode.A)) {
					float angleZ = transform.eulerAngles.z;
					//On penche la tete jusque 80° 
					if (angleZ < 75.0 || angleZ > 280.0f) {
						transform.RotateAround (transform.position, new Vector3 (0, 0, 1), 20 * Time.deltaTime);
					}


				}

				//Pencher à droite
				if (Input.GetKey (KeyCode.E)) {
					float angleZ = transform.eulerAngles.z;
					if (angleZ < 80.0 || angleZ > 285.0f) {
						transform.RotateAround (transform.position, new Vector3 (0, 0, 1), -20 * Time.deltaTime);
					}
				}


				if (lockCam == false) {

					if (Input.GetKey (KeyCode.S)) {
						angleR = transform.eulerAngles.x;
						transform.Rotate (-angleR, 0, 0);
						transform.Translate (new Vector3 (0.0f, 0.0f, -30.0f * Time.deltaTime));
						transform.Rotate (angleR, 0, 0);
					}
				} else {

					if (Input.GetKey (KeyCode.S)) {
						transform.Translate (new Vector3 (0.0f, 0.0f, -30.0f * Time.deltaTime));
					}
				}

				if (Input.GetKeyDown (KeyCode.F)) {
					if (lockCam == false) {
						lockCam = true;
					} else {
						lockCam = false;
					}
				}

			} else {
				//Pas à gauche
				if (Input.GetKey (KeyCode.Q)) {
					transform.Translate (new Vector3 (-30.0f * Time.deltaTime, 0, 0));
				}
				//Pas à droite 
				if (Input.GetKey (KeyCode.D)) {
					transform.Translate (new Vector3 (30.0f * Time.deltaTime, 0, 0));
				}


				//Rotation du torse
				float angleR = transform.eulerAngles.x;
				transform.Rotate (-angleR, 0, 0);

				float axeXMouse = Input.GetAxis ("Mouse X");
				transform.Rotate (0, axeXMouse, 0);

				transform.Rotate (angleR, 0, 0);



				//Lock du curseur souris
				if (Input.GetKeyDown (KeyCode.I)) {
					if (Cursor.lockState == CursorLockMode.Locked) {
						Cursor.lockState = CursorLockMode.None;
					} else {
						Cursor.lockState = CursorLockMode.Locked;
					}
				}

				//Lever la tête
				float axeYMouse = Input.GetAxis ("Mouse Y");
				//Debug.Log(axeYMouse);
				transform.Rotate (-axeYMouse, 0, 0);



				//Saut 
				if (Input.GetKeyDown (KeyCode.Space)) {
					StartCoroutine ("Jump");
				}


				//Lean  --> rotation de la tête
				//Pencher à gauche
				if (Input.GetKey (KeyCode.A)) {
					float angleZ = transform.eulerAngles.z;
					//On penche la tete jusque 80° 
					if (angleZ < 75.0 || angleZ > 280.0f) {
						transform.RotateAround (transform.position, new Vector3 (0, 0, 1), 20 * Time.deltaTime);
					}


				}

				//Pencher à droite
				if (Input.GetKey (KeyCode.E)) {
					float angleZ = transform.eulerAngles.z;
					if (angleZ < 80.0 || angleZ > 285.0f) {
						transform.RotateAround (transform.position, new Vector3 (0, 0, 1), -20 * Time.deltaTime);
					}
				}


				if (lockCam == false) {
					//Avancer dans la direction du torse
					//Pas en avant
					if (Input.GetKey (KeyCode.Z)) {
						angleR = transform.eulerAngles.x;
						transform.Rotate (-angleR, 0, 0);
						transform.Translate (new Vector3 (0.0f, 0.0f, 30.0f * Time.deltaTime));
						transform.Rotate (angleR, 0, 0);
					}

					if (Input.GetKey (KeyCode.S)) {
						angleR = transform.eulerAngles.x;
						transform.Rotate (-angleR, 0, 0);
						transform.Translate (new Vector3 (0.0f, 0.0f, -30.0f * Time.deltaTime));
						transform.Rotate (angleR, 0, 0);
					}
				} else {
					if (Input.GetKey (KeyCode.Z)) {
						transform.Translate (new Vector3 (0.0f, 0.0f, 30.0f * Time.deltaTime));
					}
					if (Input.GetKey (KeyCode.S)) {
						transform.Translate (new Vector3 (0.0f, 0.0f, -30.0f * Time.deltaTime));
					}
				}

				if (Input.GetKeyDown (KeyCode.F)) {
					if (lockCam == false) {
						lockCam = true;
					} else {
						lockCam = false;
					}
				}

			}
		} else {
		//Mode Saisie
			/*Renderer rend = saisie.GetComponent<Renderer> ();
				Material m = Resources.Load("Material/SaisieMaterial", typeof(Material)) as Material;
				rend.material = m;*/


			bool saisieTerminee = false;

			if (Input.GetMouseButtonDown (1)) {
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				posdebut = ray.GetPoint (10);

			} if (Input.GetMouseButtonUp (1)) {
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				posFin = ray.GetPoint (10);

				saisieTerminee = true;

			}
			if (saisieTerminee == true) {
				Material m = Resources.Load<Material> ("Materials/SaisieMaterial");
				GameObject saisie = GameObject.CreatePrimitive (PrimitiveType.Cube);
				saisie.GetComponent<MeshRenderer>().material = m;
				saisie.transform.rotation = Camera.main.transform.rotation;

				saisie.transform.localScale = new Vector3 (posFin.x-posdebut.x, Mathf.Abs(posFin.y-posdebut.y), 0.1f);
		

				Vector3 posSaisie = (posdebut+posFin)/2.0f;
				saisie.transform.position = (posSaisie);
				saisieTerminee = false;
			
			}





		
		}

	}

	IEnumerator Jump() {
		for (int h = 0; h < 30; h++) {
			transform.Translate(new Vector3(0.0f, h * Time.deltaTime * 0.2f, 0.0f));
			yield return null;
		}
		for (int h2 = 0; h2 < 30; h2++) {
			transform.Translate(new Vector3(0.0f, -h2 * Time.deltaTime * 0.2f, 0.0f));
			yield return null;
		}

	}



}
