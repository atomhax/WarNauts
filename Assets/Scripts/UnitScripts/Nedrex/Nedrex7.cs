using UnityEngine;
using System.Collections;

public class Nedrex7 : MonoBehaviour {

	UnitBrain unitBrain;
	GameObject currentUnit;


	// Use this for initialization
	void Start () {

		unitBrain = GetComponent<UnitBrain> ();

		currentUnit = null;
		//transform.position = new Vector3 (transform.position.x + (((unitBrain.axis % 2) - 1) * 0.3f * unitBrain.moveDirection), transform.position.y - ((unitBrain.axis % 2) * 0.3f * unitBrain.moveDirection), 0f);  
	}
	
	// Update is called once per frame
	void Update () {
		if (currentUnit != null) {
			currentUnit.transform.position = new Vector3(transform.position.x-(((unitBrain.axis%2)-1)*0.3f*unitBrain.moveDirection),transform.position.y+((unitBrain.axis%2)*0.3f*unitBrain.moveDirection),0f) ;   
		}
	}

	void FixedUpdate () {
		if (unitBrain.enteredRange != null) {
			if ((unitBrain.enteredRange.GetComponent<colliderBrain> ().type == 0) && (currentUnit == null)) {
				if (unitBrain.enteredRange.GetComponent<UnitBrain> ().team == unitBrain.team) {
					currentUnit = unitBrain.enteredRange;
					unitBrain.speed = unitBrain.speed/2 ;

				}
			}
			unitBrain.enteredRange = null;
		}
	}
}