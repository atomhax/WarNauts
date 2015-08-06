using UnityEngine;
using System.Collections;

public class Chronowarpers5 : MonoBehaviour {

	UnitBrain unitBrain;

	// Use this for initialization
	void Start () {
		//Debug.Log ("Start");
		unitBrain = GetComponent<UnitBrain> ();
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log ("Running");
	}

	//Use LateUpdate for calls after UnitBrain
}