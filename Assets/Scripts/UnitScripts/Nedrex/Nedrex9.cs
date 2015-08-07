using UnityEngine;
using System.Collections;

public class Nedrex9 : MonoBehaviour {
	UnitBrain unitBrain;
	
	// Use this for initialization
	void Start () {
		//Debug.Log ("Start");
		unitBrain = GetComponent<UnitBrain> ();
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log ("Running");
		if (unitBrain.currentHealth <= 0f) {
			GameObject explo = Instantiate(Resources.Load<GameObject>("explosion")) ;
			explo.GetComponent<explosionBrain>().explosionDamage = 200f ;
			explo.GetComponent<explosionBrain>().explosionSize = 1.5f ;
			explo.GetComponent<explosionBrain>().explosionTime = 0.2f ;
			explo.transform.position = transform.position ;
		}
	}
}
