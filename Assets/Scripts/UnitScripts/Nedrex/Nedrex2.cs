using UnityEngine;
using System.Collections;

public class Nedrex2 : MonoBehaviour {

	UnitBrain unitBrain;
	
	// Use this for initialization
	void Start () {
		//Debug.Log ("Start");
		unitBrain = GetComponent<UnitBrain> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (unitBrain.enemy!=null) {
			GameObject explo = Instantiate(Resources.Load<GameObject>("explosion")) ;
			explo.GetComponent<explosionBrain>().explosionDamage = 200f ;
			explo.GetComponent<explosionBrain>().explosionSize = 0.3f ;
			explo.GetComponent<explosionBrain>().explosionTime = 0.4f ;
			explo.transform.position = transform.position ;
			Destroy(gameObject) ;
		}
	}
}