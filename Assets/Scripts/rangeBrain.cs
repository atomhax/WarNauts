using UnityEngine;
using System.Collections;

public class rangeBrain : MonoBehaviour {


	void OnTriggerExit2D(Collider2D other) { 
		if((other.gameObject.GetComponent<colliderBrain>().type == 0)) {
			if (other.gameObject.GetComponent<UnitBrain>().team != gameObject.GetComponentInParent<UnitBrain>().team) {
				transform.parent.GetComponent<UnitBrain>().enemy = null ;
			}
		}
	}

	void OnTriggerStay2D(Collider2D other) {
		if((other.gameObject.GetComponent<colliderBrain>().type == 0)) {
			//if (other.gameObject.GetComponent<UnitBrain>().axis != gameObject.GetComponentInParent<UnitBrain>().axis) {
			if (other.gameObject.GetComponent<UnitBrain>().team != gameObject.GetComponentInParent<UnitBrain>().team) {
				transform.parent.GetComponent<UnitBrain>().enemy = other.gameObject ;
			}
		}
	}

	void OnTriggerEnter2D(Collider2D other) { 
		//transform.parent.GetComponent<UnitBrain> ().enteredRange = other.gameObject;
	}
}