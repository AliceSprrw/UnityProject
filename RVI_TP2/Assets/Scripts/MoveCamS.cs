using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveCamS : MonoBehaviour {
	public Button avant;
	public Button arriere;
	public Button droite;
	public Button gauche;

	public Text posCam;

	public GameObject c;
	// Use this for initialization
	void Start () {
		
		Button btnA = avant.GetComponent<Button>();
		btnA.onClick.AddListener(TaskAvant);

		Button btnArr = arriere.GetComponent<Button>();
		btnArr.onClick.AddListener(TaskArr);

		Button btnD = droite.GetComponent<Button>();
		btnD.onClick.AddListener(TaskD);

		Button btnG = gauche.GetComponent<Button>();
		btnG.onClick.AddListener(TaskG);




	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt(c.transform);
		posCam.text = transform.position.ToString() ;
	}

	void TaskAvant(){
		transform.Translate(new Vector3(0.0f, 0.0f, 30.0f * Time.deltaTime));
	}

	void TaskArr(){
		transform.Translate(new Vector3(0.0f, 0.0f, -30.0f * Time.deltaTime));
	}

	void TaskD(){
		transform.Translate(new Vector3(30.0f * Time.deltaTime , 0, 0));
	}

	void TaskG(){
		transform.Translate(new Vector3(-30.0f * Time.deltaTime, 0, 0));
	}
}
