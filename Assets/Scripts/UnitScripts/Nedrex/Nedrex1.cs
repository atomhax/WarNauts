using UnityEngine;
using System.Collections;

public class Nedrex1 : MonoBehaviour {

	//UnitBrain unitBrain;

	void Start () {
		//Debug.Log ("Start");
		//unitBrain = GetComponent<UnitBrain> ();
	}
	
	// Update is called once per frame
	void Update() {
		if (Random.value<0.015) {
			transform.Rotate(new Vector3(0f,0f,transform.rotation.z+((Random.value*15f)-7.5f))) ;
		}
	}
}
