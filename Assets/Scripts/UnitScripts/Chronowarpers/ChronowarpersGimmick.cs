using UnityEngine;
using System.Collections;

public class ChronowarpersGimmick : MonoBehaviour {

	short teleCount;
	UnitBrain unitBrain;

	// Use this for initialization
	void Start () {
		teleCount = 1;

		unitBrain = GetComponent<UnitBrain> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (unitBrain.currentHealth < unitBrain.maxHealth/5 && teleCount > 0) {
			if (Random.value<0.3) {
				if (unitBrain.enemy!=null) {
					if (unitBrain.axis%2==0) {
						transform.position = new Vector3 (unitBrain.enemy.transform.position.x+(0.3f*unitBrain.moveDirection),transform.position.y,transform.position.z) ;
					} else {
						transform.position = new Vector3 (transform.position.x,unitBrain.enemy.transform.position.y+(0.3f*unitBrain.moveDirection),transform.position.z) ;
					}
				}
			}
			teleCount-- ;
		}
	}
}
