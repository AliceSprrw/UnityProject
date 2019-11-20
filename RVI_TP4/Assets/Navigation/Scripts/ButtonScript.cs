using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour {
	public Button button1;
	public Button button2;

	public Camera cam1;
	public Camera cam2;


	// Use this for initialization
	void Start () {
		Button btn1 = button1.GetComponent<Button>();
		btn1.onClick.AddListener(changeToCam1);


		Button btn2 = button2.GetComponent<Button>();
		btn2.onClick.AddListener(changeToCam2);
	}

	// Update is called once per frame
	void Update () {

	}

	void changeToCam1(){
		 
		cam1.enabled = true;
		cam1.transform.position = cam2.transform.position;
		var script = cam2.GetComponent<PointageScript>();
		script.enabled = false;
		//cam1.transform.rotation = cam2.transform.rotation;
		cam2.enabled = false;
	}


	void changeToCam2(){
		cam1.enabled = false; 
		cam2.enabled = true;
		cam2.transform.position = cam1.transform.position;
		var script = cam2.GetComponent<PointageScript>();
		script.enabled = true;
		//cam2.transform.rotation = cam1.transform.rotation;

	}

}
