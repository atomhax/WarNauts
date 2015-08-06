using UnityEngine;
using System.Collections;

public class Chronowarpers7 : MonoBehaviour {

	UnitBrain unitBrain;

	// Use this for initialization
	void Start () {
		//Debug.Log ("Start");
		unitBrain = GetComponent<UnitBrain> ();
	}

	void FixedUpdate () {
		if (unitBrain.enteredRange != null) {
			if((unitBrain.enteredRange.GetComponent<colliderBrain>().type == 0)) {
				if (unitBrain.enteredRange.GetComponent<UnitBrain>().team == unitBrain.team) {
					if (unitBrain.axis % 2 == 0) {
						unitBrain.enteredRange.transform.position = new Vector3 (transform.position.x-(0.3f*unitBrain.enteredRange.GetComponent<UnitBrain>().moveDirection),unitBrain.enteredRange.transform.position.y,transform.position.z) ;
					} else {
						unitBrain.enteredRange.transform.position = new Vector3 (unitBrain.enteredRange.transform.position.x,transform.position.y-(0.3f*unitBrain.enteredRange.GetComponent<UnitBrain>().moveDirection),transform.position.z) ;
					}
				}
			}
			unitBrain.enteredRange = null;
		}
	}


	//Use LateUpdate for calls after UnitBrain
}