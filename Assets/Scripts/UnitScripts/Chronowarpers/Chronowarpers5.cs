using UnityEngine;
using System.Collections;

public class Chronowarpers5 : MonoBehaviour {

	UnitBrain unitBrain;
	float teleChance;
	
	// Use this for initialization
	void Start () {
		//Debug.Log ("Start");
		teleChance = 0.2f;
		unitBrain = GetComponent<UnitBrain> ();
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log ("Running");
		if (unitBrain.enemy != null) {
			if (Random.value < teleChance) {
				if (unitBrain.axis%2==0) {
					transform.position = new Vector3 (unitBrain.enemy.transform.position.x+(0.3f*unitBrain.moveDirection),transform.position.y,transform.position.z) ;
				} else {
					transform.position = new Vector3 (transform.position.x,unitBrain.enemy.transform.position.y+(0.3f*unitBrain.moveDirection),transform.position.z) ;
				}
			}
		}
	}

	//Use LateUpdate for calls after UnitBrain
}