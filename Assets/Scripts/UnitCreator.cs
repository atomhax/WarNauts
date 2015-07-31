using UnityEngine;
using UnityEngine.UI ;
using System.Collections;

public class UnitCreator : MonoBehaviour {

	public GameObject unit1 ;
	public string input ;
	GameObject newUnit ;
	public selectorBrain selector ; 
	public globalVariables variables;
	float[] unitCooldowns ;
	public GameObject race;
	public string team ;

	// Use this for initialization
	void Start () {
		unitCooldowns = new float[race.GetComponent<Race>().unitAmount];
		for (int i = 0; i < unitCooldowns.Length; i++) {
			unitCooldowns[i] = race.GetComponent<Race>().unitCooldown[i];
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown (input)) {
			if (unitCooldowns[selector.currentlySelected] <= 0f) {
				newUnit = (GameObject) Instantiate(unit1,transform.position,Quaternion.identity) ;
				UnitBrain brain = newUnit.GetComponent<UnitBrain>();
				//brain.type = selector.currentlySelected;
				brain.speed = race.GetComponent<Race>().unitSpeed[selector.currentlySelected] ;
				brain.armor = race.GetComponent<Race>().unitArmor[selector.currentlySelected] ;
				brain.maxHealth = race.GetComponent<Race>().unitMaxHealth[selector.currentlySelected] ;
				brain.atkDelay = race.GetComponent<Race>().unitAtkDelay[selector.currentlySelected] ;
				brain.damage = race.GetComponent<Race>().unitAtkDamage[selector.currentlySelected] ;
				brain.range = race.GetComponent<Race>().unitRange[selector.currentlySelected] ;
				brain.createAbility = race.GetComponent<Race>().createAbility[selector.currentlySelected] ;
				brain.collisionAbility = race.GetComponent<Race>().collisionAbility[selector.currentlySelected] ;
				brain.passiveAbility = race.GetComponent<Race>().passiveAbility[selector.currentlySelected] ;
				brain.deathAbility = race.GetComponent<Race>().deathAbility[selector.currentlySelected] ;
				brain.raceGimmick = race.GetComponent<Race>().raceGimmick ;
				brain.mySprite = race.GetComponent<Race>().unitSprite[selector.currentlySelected] ;
				brain.healthBar = newUnit.gameObject.transform.GetChild(0).GetChild(0).gameObject.GetComponent<Slider>() ;
				brain.axis = GetComponent<ArrowMovement>().axis ;
				brain.team = team ;
				brain.row = gameObject.GetComponent<ArrowMovement>().currentRow ;

				for (int i = 0; i < unitCooldowns.Length; i++) {
					unitCooldowns[i] = race.GetComponent<Race>().unitCooldown[i];
				}
			}
		}

		for (int i = 0; i < unitCooldowns.Length; i++) {
			unitCooldowns[i] -= Time.deltaTime;
			selector.transform.GetChild(i).transform.GetChild(0).transform.localScale = new Vector3(Mathf.Clamp(((unitCooldowns[i]/race.GetComponent<Race>().unitCooldown[i])+0.1f),0f,1f),Mathf.Clamp(((unitCooldowns[i]/race.GetComponent<Race>().unitCooldown[i])+0.1f),0f,1f),0f) ;
		}
		selector.GetComponent<selectorBrain>().bigPreview.transform.GetChild(0).transform.localScale =  new Vector3(Mathf.Clamp(((unitCooldowns[selector.GetComponent<selectorBrain>().currentlySelected]/race.GetComponent<Race>().unitCooldown[selector.GetComponent<selectorBrain>().currentlySelected])+0.1f),0f,1f),Mathf.Clamp(((unitCooldowns[selector.GetComponent<selectorBrain>().currentlySelected]/race.GetComponent<Race>().unitCooldown[selector.GetComponent<selectorBrain>().currentlySelected])+0.1f),0f,1f),0f) ;


	}
}
