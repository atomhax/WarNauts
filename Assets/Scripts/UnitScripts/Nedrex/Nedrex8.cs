using UnityEngine;
using System.Collections;

public class Nedrex8 : MonoBehaviour {
	UnitBrain unitBrain ;
	// Use this for initialization
	void Start () {
		unitBrain = GetComponent<UnitBrain> ();
		if (unitBrain.name == "Unit(Clone)") {
			for (int i=-1; i<2; i+=1) {
				GameObject newUnit = Instantiate (gameObject);
				newUnit.transform.position = new Vector3 (transform.position.x + ((unitBrain.axis % 2) * 0.6f*i), transform.position.y - (((unitBrain.axis % 2) - 1) * 0.6f*i), 0f);
				switch (newUnit.GetComponent<UnitBrain> ().axis) {
				case 0:
					newUnit.GetComponent<UnitBrain> ().moveDirection = -1;
					newUnit.transform.localScale = new Vector3 ((-1f) * newUnit.transform.localScale.x, newUnit.transform.localScale.y, newUnit.transform.localScale.z);
					break;
				case 1:
					newUnit.GetComponent<UnitBrain> ().moveDirection = -1; 
					newUnit.transform.Rotate (new Vector3 (0, 0, -90));
					break;
				case 2:
					newUnit.GetComponent<UnitBrain> ().moveDirection = 1;
					break;
				case 3:
					newUnit.transform.Rotate (new Vector3 (0, 0, 90));
					newUnit.GetComponent<UnitBrain> ().moveDirection = 1;
					break;
				}
			}
			Destroy(gameObject) ;
		}
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