using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrInit : MonoBehaviour {
	public GameObject grass;
	public GameObject water;
	public GameObject hovel;
	public GameObject tree;


	// Use this for initialization
	void Start () {
		
		for(int x=0; x!=80; x=x+8){
			for(int z=0; z!=80; z=z+8){
				int r = Random.Range(0,2);
				if (r == 0) {
					Instantiate (grass, new Vector3(x,0,z),new Quaternion(-1,0,0,1));
					if (x < 72 && z < 72) {
						int nb = Random.Range (0, 10);
						for(int t=0; t!=nb; t++){
							int r2 = Random.Range (0, 2);
							if (r2 == 0) {
								Instantiate (tree, new Vector3 (Random.Range (x, x + 8), 2, Random.Range (z, z + 8)), new Quaternion (-1, 0, 0, 1));
							}
							if (r2 == 1) {
								Instantiate (hovel, new Vector3 (Random.Range (x, x + 8), 2, Random.Range (z, z + 8)), new Quaternion (-1, 0, 0, 1));
							}
						}
					}

				}
				if (r == 1) {
					Instantiate (water, new Vector3(x,0,z),new Quaternion(-1,0,0,1));
				}
			}

		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
