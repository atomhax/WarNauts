using UnityEngine;
using UnityEngine.UI ;
using System.Collections;

public class UnitBrain : MonoBehaviour {

	public int type ;
	public float speed ;
	public float damage ;
	public float atkDelay ;
	public float range ;
	public float maxHealth ;
	public float armor ;
	public Slider healthBar ;
	public string team ;
	public short axis ;
	public GameObject enemy ;
	public float hspeed ;
	public Sprite mySprite ;
	public AbilityDelegate createAbility ;
	public AbilityDelegate passiveAbility ;
	public AbilityDelegate collisionAbility ;
	public int row ;
	public Rigidbody2D rbd ;
	
	public float[] abilityNumbers = new float[10] ;
	public float atkCooldown ;


	public short moveDirection ;
	public float currentHealth;

	void Start () {
		rbd = GetComponent<Rigidbody2D> ();
		healthBar.value = 1;
		hspeed = speed;
		atkCooldown = 0;
		
		gameObject.GetComponent<SpriteRenderer> ().sprite = mySprite;
		gameObject.transform.GetChild (1).GetComponent<BoxCollider2D> ().size = new Vector2 (range,0.25f);	
		gameObject.transform.GetChild (1).GetComponent<BoxCollider2D> ().offset += new Vector2 ((range-0.87f)/2,0);	


		currentHealth = maxHealth ;

		switch (axis) {
			case 0 :
			moveDirection = -1 ;
			transform.localScale = new Vector3((-1f)*transform.localScale.x,transform.localScale.y,transform.localScale.z) ;
			break;
			case 1 :
			moveDirection = -1 ; 
			transform.Rotate(new Vector3(0,0,-90)) ;
			break;
			case 2 :
			moveDirection = 1 ;
			break;
			case 3 :
			transform.Rotate(new Vector3(0,0,90)) ;
			moveDirection = 1 ;
			break;
		}
		createAbility (gameObject);
	}

	void FixedUpdate () {
		healthBar.value = ((currentHealth)/(maxHealth)); 
		passiveAbility (gameObject);

		if ((currentHealth <= 0)) {
			Destroy(gameObject) ;
		} 
		
	}
}
