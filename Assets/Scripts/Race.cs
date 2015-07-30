using UnityEngine;
using System.Collections;
//public delegate void AbilityDelegate () ;

public class Race : MonoBehaviour {

	public string raceName ;
	//public string 
	public int unitAmount ;
	public string[] unitName ; 
	public float[] unitSpeed ;
	public float[] unitAtkDelay ;
	public float[] unitAtkDamage ;
	public float[] unitMaxHealth ;
	public float[] unitArmor ;
	public float[] unitRange ;
	public Sprite[] unitSprite ;
	public float[] unitCooldown ;
	public AbilityDelegate[] createAbility ;
	public AbilityDelegate[] passiveAbility ;
	public AbilityDelegate[] collisionAbility ;

	//void 
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
}
