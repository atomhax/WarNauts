using UnityEngine;
using System.Collections;

public class Chronowarpers6 : MonoBehaviour {

	UnitBrain unitBrain;
	float regenRate;

	// Use this for initialization
	void Start () {
		//Debug.Log ("Start");
		unitBrain = GetComponent<UnitBrain> ();
		regenRate = 30;
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log ("Running");
		unitBrain.currentHealth += regenRate * Time.deltaTime ;
	}

	//Use LateUpdate for calls after UnitBrain
}