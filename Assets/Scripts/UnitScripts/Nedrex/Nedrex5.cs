using UnityEngine;
using System.Collections;

public class Nedrex5 : MonoBehaviour {
	UnitBrain unitBrain ;
	float sandbagDelay ;
	// Use this for initialization
	void Start () {
		unitBrain = GetComponent<UnitBrain> ();
		sandbagDelay = (Random.value*(5f-2.5f))+2.5f ;	
	}
	// Update is called once per frame
	void Update () {
		sandbagDelay-=Time.deltaTime ;
		if (sandbagDelay<=0) {
			sandbagDelay = (Random.value*(5f-2.5f))+2.5f ;
			GameObject sandBag = Instantiate(Resources.Load<GameObject>("unit")) ;
			UnitBrain sandBrain = sandBag.GetComponent<UnitBrain>() ;
			sandBrain.range = unitBrain.creator.GetComponent<UnitCreator>().race.GetComponent<Race>().unitRange[6] ;
			sandBrain.atkDelay = unitBrain.creator.GetComponent<UnitCreator>().race.GetComponent<Race>().unitAtkDelay[6] ;
			sandBrain.damage = unitBrain.creator.GetComponent<UnitCreator>().race.GetComponent<Race>().unitAtkDamage[6] ;
			sandBrain.speed = unitBrain.creator.GetComponent<UnitCreator>().race.GetComponent<Race>().unitSpeed[6] ;
			sandBrain.maxHealth = unitBrain.creator.GetComponent<UnitCreator>().race.GetComponent<Race>().unitMaxHealth[6] ;
			sandBrain.armor = unitBrain.creator.GetComponent<UnitCreator>().race.GetComponent<Race>().unitArmor[6] ;
			sandBrain.mySprite = unitBrain.creator.GetComponent<UnitCreator>().race.GetComponent<Race>().unitSprite[6] ;
			sandBrain.team = unitBrain.team ;
			sandBag.transform.position = gameObject.transform.position ;
			sandBrain.row = unitBrain.row ;
			sandBrain.creator = unitBrain.creator ;
			sandBag.AddComponent<NedrexGimmick>();
			sandBag.AddComponent<Nedrex6>();
		}
	}
}
