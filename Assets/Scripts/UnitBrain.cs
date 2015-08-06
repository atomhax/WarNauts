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
	public GameObject enteredRange ;
	public GameObject creator ;
	public float hspeed ;
	public Sprite mySprite ;
	//public AbilityDelegate createAbility ;
	//public AbilityDelegate passiveAbility ;
	//public AbilityDelegate deathAbility ;
	//public CollisionDelegate collisionAbility ;
	public int row ;
	public Rigidbody2D rbd ;
	
	//public float[] abilityNumbers = new float[10] ;
	//public GameObject[] abilityObjects = new GameObject[3] ;
	public float atkCooldown ;


	public short moveDirection ;
	public float currentHealth;

	void Start () {
		healthBar = transform.GetChild(0).GetChild(0).gameObject.GetComponent<Slider>() ;
		rbd = GetComponent<Rigidbody2D> ();
		healthBar.value = 1;
		hspeed = speed;
		atkCooldown = 0;
		
		gameObject.GetComponent<SpriteRenderer> ().sprite = mySprite;
		gameObject.transform.GetChild (1).GetComponent<BoxCollider2D> ().size = new Vector2 (range,0.25f);	
		gameObject.transform.GetChild (1).GetComponent<BoxCollider2D> ().offset += new Vector2 ((range-0.87f)/2,0);	
		//Debug.Log ("START!!");


		currentHealth = maxHealth ;

		moveDirection = 1;
		switch (axis) {
			case 0 :
			moveDirection = -1 ;
			transform.localScale = new Vector3((-1f)*transform.localScale.x,transform.localScale.y,transform.localScale.z) ;
			break;
			case 1 : 
			transform.Rotate(new Vector3(0,0,-90)) ;
			break;
			case 2 :
			break;
			case 3 :
			transform.Rotate(new Vector3(0,0,90)) ;
			break;
		}
		//raceGimmick (gameObject, 0);
		//createAbility (gameObject);
	}

	void LateUpdate (){
		atkCooldown -= 1000 * Time.deltaTime;
		if (enemy != null) {
			hspeed = 0f;
			if (atkCooldown <= 0) {
				atkCooldown = atkDelay;
				enemy.GetComponent<UnitBrain> ().currentHealth -= damage - enemy.GetComponent<UnitBrain> ().armor;
				if (enemy.GetComponent<UnitBrain> ().currentHealth <= 0) {
					enemy = null;
				}
			}
			
		} else {
			hspeed = speed;
		}
		if (Mathf.Abs (transform.position.x) > 5.41) {
			Destroy (gameObject);
		}
		if (Mathf.Abs (transform.position.y) > 5.41) {
			Destroy (gameObject);
		}
		
		healthBar.value = ((currentHealth)/(maxHealth)); 
		//raceGimmick (gameObject, 1);
		//passiveAbility (gameObject);
		
		if ((currentHealth <= 0)) {
			//deathAbility(gameObject) ;
			//raceGimmick (gameObject, 2);
			Destroy(gameObject) ;
		} 
	}


	void FixedUpdate () {
		GetComponent<Rigidbody2D>().MovePosition(new Vector2 
		 	(GetComponent<Rigidbody2D>().position.x + (hspeed* Time.fixedDeltaTime * moveDirection * Mathf.Cos(transform.rotation.eulerAngles.z * Mathf.Deg2Rad)), 
		 	 GetComponent<Rigidbody2D>().position.y + (hspeed* Time.fixedDeltaTime * moveDirection * Mathf.Sin(transform.rotation.eulerAngles.z * Mathf.Deg2Rad)))) ;
		
	}
}
