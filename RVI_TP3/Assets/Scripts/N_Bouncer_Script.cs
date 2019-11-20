using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N_Bouncer_Script : MonoBehaviour {
	public int n_bouncer;
	public GameObject prefab;
	// Use this for initialization
	void Start () {
		for (int i = 0; i < n_bouncer; i++) {
			
			Instantiate(prefab, new Vector3(Random.Range(-4.5f, 4.5f), 0, Random.Range(-4.5f, 4.5f)), Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
