using UnityEngine;
using System.Collections;

public class Nedrex3 : MonoBehaviour {
	UnitBrain unitBrain;
	GameObject newUnit ;
	
	// Use this for initialization
	void Start () {
		//Debug.Log ("Start");
		unitBrain = GetComponent<UnitBrain> ();
	}
	
	// Update is called once per frame
	void Update () {
	if (unitBrain.atkCooldown <= 3&&unitBrain.enemy!=null) {
		if (unitBrain.enemy.GetComponent<UnitBrain> ().currentHealth-unitBrain.damage <= 0) {
				Debug.Log("I killed a man with this thumb") ;
				newUnit = Instantiate(gameObject) ;
				newUnit.GetComponent<UnitBrain>().speed = (Random.value+0.5f)*newUnit.GetComponent<UnitBrain>().speed ;
				newUnit.GetComponent<UnitBrain>().copy = true ;
			}
		}
	}
} 