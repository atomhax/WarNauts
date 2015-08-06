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
	if (unitBrain.atkCooldown <= 0&&unitBrain.enemy!=null) {
		if (unitBrain.enemy.GetComponent<UnitBrain> ().currentHealth <= 0) {
				newUnit = Instantiate(gameObject) ;
				newUnit.GetComponent<UnitBrain>().speed = (Random.value+0.5f)*newUnit.GetComponent<UnitBrain>().speed ;
				/*switch (newUnit.GetComponent<UnitBrain>().axis) {
				case 0 :
					newUnit.GetComponent<UnitBrain>().moveDirection = -1 ;
					newUnit.transform.localScale = new Vector3((-1f)*newUnit.transform.localScale.x,newUnit.transform.localScale.y,newUnit.transform.localScale.z) ;
					break;
				case 1 :
					newUnit.GetComponent<UnitBrain>().moveDirection = -1 ; 
					newUnit.transform.Rotate(new Vector3(0,0,-90)) ;
					break;
				case 2 :
					newUnit.GetComponent<UnitBrain>().moveDirection = 1 ;
					break;
				case 3 :
					newUnit.transform.Rotate(new Vector3(0,0,90)) ;
					newUnit.GetComponent<UnitBrain>().moveDirection = 1 ;
					break;
				}
				newUnit.transform.GetChild (1).GetComponent<BoxCollider2D> ().size = new Vector2 (unitBrain.range,0.25f);
				newUnit.transform.GetChild (1).GetComponent<BoxCollider2D> ().offset = new Vector2 (0.6f,0f);	*/
			}
		}
	}
} 