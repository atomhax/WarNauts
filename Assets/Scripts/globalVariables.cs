using UnityEngine;
using System.Collections;
//public delegate void AbilityDelegate (GameObject me) ;
//public delegate void CollisionDelegate (GameObject me, GameObject other) ;
//public delegate void GimmickDelegate (GameObject me, int mode) ;
public class globalVariables : MonoBehaviour {
	
	public float rowHeight = 0.6f ;
	[Range(0.0001f, 1.0f)] 
	public float baseCooldown ;
	public int raceAmount ;
	public int[] raceUnits ;
	public float previewScale ;
	public float[] baseUnitCooldowns ;
	public string[] unitNames ;
	public string[] unitDescriptions ;
	public GameObject[] raceArray ;
	int unitAmount ;
	//AbilityDelegate defaultPassiveAbility (GameObject me) ;
	
	
	
	void Awake () {
		Application.targetFrameRate = 60;
		raceAmount = 2;
		raceArray = new GameObject[raceAmount];
		
		for (int i = 0; i < raceAmount; i++) {
			raceArray[i] = new GameObject() ;
			raceArray[i].AddComponent<Race>();
			raceArray[i].transform.parent = transform;
		}
		//baseCooldown = 0.174f ;
		//raceUnits = new int[raceAmount] ;
		//raceArray = new GameObject[raceAmount];
		
		unitAmount = 9;
		raceArray [0].GetComponent<Race>().unitAmount = unitAmount ;
		
		raceArray[0].GetComponent<Race>().unitName = new string[unitAmount] ;
		raceArray[0].GetComponent<Race>().unitSpeed = new float[unitAmount] ;
		raceArray[0].GetComponent<Race>().unitAtkDelay = new float[unitAmount] ;
		raceArray[0].GetComponent<Race>().unitAtkDamage = new float[unitAmount] ;
		raceArray [0].GetComponent<Race> ().unitRange = new float[unitAmount];
		raceArray[0].GetComponent<Race>().unitMaxHealth = new float[unitAmount] ;
		raceArray[0].GetComponent<Race>().unitArmor = new float[unitAmount] ;
		raceArray[0].GetComponent<Race>().unitCooldown = new float[unitAmount] ;
		raceArray[0].GetComponent<Race>().unitSprite = new Sprite[unitAmount] ;
		
		
		
		raceArray [0].GetComponent<Race>().raceName = "Chronowarpers";
		raceArray [0].transform.name = raceArray [0].GetComponent<Race>().raceName;
		
		
		raceArray[0].GetComponent<Race>().unitName[0] = "Moment" ;
		raceArray [0].GetComponent<Race>().unitSpeed [0] = 0.8f; 	
		raceArray [0].GetComponent<Race>().unitAtkDelay [0] = 1000f;	
		raceArray [0].GetComponent<Race>().unitAtkDamage [0] = 20f;		
		raceArray [0].GetComponent<Race>().unitMaxHealth [0] = 140f;		
		raceArray [0].GetComponent<Race>().unitArmor [0] = 0f;	
		raceArray [0].GetComponent<Race>().unitSprite [0] = Resources.Load<Sprite> (raceArray [0].transform.name + "/0");	
		raceArray [0].GetComponent<Race>().unitCooldown [0] = 2.2f;	
		raceArray [0].GetComponent<Race>().unitRange [0] = 0.87f;	
		
		raceArray[0].GetComponent<Race>().unitName[1] = "Jiffy" ;		 
		raceArray [0].GetComponent<Race>().unitSpeed [1] = 1.2f; 	
		raceArray [0].GetComponent<Race>().unitAtkDelay [1] = 500f;		
		raceArray [0].GetComponent<Race>().unitAtkDamage [1] = 10f;		
		raceArray [0].GetComponent<Race>().unitMaxHealth [1] = 150f;		
		raceArray [0].GetComponent<Race>().unitArmor [1] = 0f;	
		raceArray [0].GetComponent<Race>().unitSprite [1] = Resources.Load<Sprite> (raceArray [0].transform.name + "/1");	
		raceArray [0].GetComponent<Race>().unitCooldown [1] = 3.0f; 
		raceArray [0].GetComponent<Race>().unitRange [1] = 1.0f;	
		
		raceArray[0].GetComponent<Race>().unitName[2] = "Century" ;		 
		raceArray [0].GetComponent<Race>().unitSpeed [2] = 0.3f; 	
		raceArray [0].GetComponent<Race>().unitAtkDelay [2] = 100f;		
		raceArray [0].GetComponent<Race>().unitAtkDamage [2] = 5.5f;	
		raceArray [0].GetComponent<Race>().unitMaxHealth [2] = 350f;		
		raceArray [0].GetComponent<Race>().unitArmor [2] = 3f;	
		raceArray [0].GetComponent<Race>().unitSprite [2] = Resources.Load<Sprite> (raceArray [0].transform.name + "/2");	
		raceArray [0].GetComponent<Race>().unitCooldown [2] = 4.0f; 
		raceArray [0].GetComponent<Race>().unitRange [2] = 0.5f;	
		
		raceArray[0].GetComponent<Race>().unitName[3] = "Eon" ;		 	
		raceArray [0].GetComponent<Race>().unitSpeed [3] = 0.35f;	
		raceArray [0].GetComponent<Race>().unitAtkDelay [3] = 4200f;	
		raceArray [0].GetComponent<Race>().unitAtkDamage [3] = 100f;	
		raceArray [0].GetComponent<Race>().unitMaxHealth [3] = 100f;		
		raceArray [0].GetComponent<Race>().unitArmor [3] = 2f;	
		raceArray [0].GetComponent<Race>().unitSprite [3] = Resources.Load<Sprite> (raceArray [0].transform.name + "/3");	
		raceArray [0].GetComponent<Race>().unitCooldown [3] = 5.0f; 
		raceArray [0].GetComponent<Race>().unitRange [3] = 3.6f;	
		
		raceArray[0].GetComponent<Race>().unitName[4] = "Leap Year" ;	 
		raceArray [0].GetComponent<Race>().unitSpeed [4] = 0.25f;	
		raceArray [0].GetComponent<Race>().unitAtkDelay [4] = 400f;		
		raceArray [0].GetComponent<Race>().unitAtkDamage [4] = 20f;		
		raceArray [0].GetComponent<Race>().unitMaxHealth [4] = 160f;		
		raceArray [0].GetComponent<Race>().unitArmor [4] = 3f;	
		raceArray [0].GetComponent<Race>().unitSprite [4] = Resources.Load<Sprite> (raceArray [0].transform.name + "/4");	
		raceArray [0].GetComponent<Race>().unitCooldown [4] = 3.7f; 
		raceArray [0].GetComponent<Race>().unitRange [4] = 0.9f;
		
		raceArray[0].GetComponent<Race>().unitName[5] = "NanoSecond" ;	
		raceArray [0].GetComponent<Race>().unitSpeed [5] = 0.9f;	
		raceArray [0].GetComponent<Race>().unitAtkDelay [5] = 600f;		
		raceArray [0].GetComponent<Race>().unitAtkDamage [5] = 10f;		
		raceArray [0].GetComponent<Race>().unitMaxHealth [5] = 80f;			
		raceArray [0].GetComponent<Race>().unitArmor [5] = 0f;	
		raceArray [0].GetComponent<Race>().unitSprite [5] = Resources.Load<Sprite> (raceArray [0].transform.name + "/5");	
		raceArray [0].GetComponent<Race>().unitCooldown [5] = 2.8f; 
		raceArray [0].GetComponent<Race>().unitRange [5] = 0.4f;
		
		raceArray[0].GetComponent<Race>().unitName[6] = "Lifetime" ;	 
		raceArray [0].GetComponent<Race>().unitSpeed [6] = 0.6f;	
		raceArray [0].GetComponent<Race>().unitAtkDelay [6] = 1700f;	
		raceArray [0].GetComponent<Race>().unitAtkDamage [6] = 20f;		
		raceArray [0].GetComponent<Race>().unitMaxHealth [6] = 220f;		
		raceArray [0].GetComponent<Race>().unitArmor [6] = 0f;	
		raceArray [0].GetComponent<Race>().unitSprite [6] = Resources.Load<Sprite> (raceArray [0].transform.name + "/6");	
		raceArray [0].GetComponent<Race>().unitCooldown [6] = 3.7f; 
		raceArray [0].GetComponent<Race>().unitRange [6] = 1.1f;
		
		raceArray[0].GetComponent<Race>().unitName[7] = "Meridian" ;	 
		raceArray [0].GetComponent<Race>().unitSpeed [7] = 1.0f;	
		raceArray [0].GetComponent<Race>().unitAtkDelay [7] = 1000f;	
		raceArray [0].GetComponent<Race>().unitAtkDamage [7] = 20f;		
		raceArray [0].GetComponent<Race>().unitMaxHealth [7] = 420f;		
		raceArray [0].GetComponent<Race>().unitArmor [7] = 4f;	
		raceArray [0].GetComponent<Race>().unitSprite [7] = Resources.Load<Sprite> (raceArray [0].transform.name + "/7");	
		raceArray [0].GetComponent<Race>().unitCooldown [7] = 6.5f; 
		raceArray [0].GetComponent<Race>().unitRange [7] = 0.8f;
		
		raceArray[0].GetComponent<Race>().unitName[8] = "Millenium" ;	 
		raceArray [0].GetComponent<Race>().unitSpeed [8] = 0.1f;	
		raceArray [0].GetComponent<Race>().unitAtkDelay [8] = 60f;		
		raceArray [0].GetComponent<Race>().unitAtkDamage [8] = 5f;		
		raceArray [0].GetComponent<Race>().unitMaxHealth [8] = 700f;	
		raceArray [0].GetComponent<Race>().unitArmor [8] = 6f;	
		raceArray [0].GetComponent<Race>().unitSprite [8] = Resources.Load<Sprite> (raceArray [0].transform.name + "/8");
		raceArray [0].GetComponent<Race>().unitCooldown [8] = 10f;
		raceArray [0].GetComponent<Race>().unitRange [8] = 0.6f;



		unitAmount = 10;
		raceArray [1].GetComponent<Race>().unitAmount = unitAmount ;
		
		raceArray[1].GetComponent<Race>().unitName = new string[unitAmount] ;
		raceArray[1].GetComponent<Race>().unitSpeed = new float[unitAmount] ;
		raceArray[1].GetComponent<Race>().unitAtkDelay = new float[unitAmount] ;
		raceArray[1].GetComponent<Race>().unitAtkDamage = new float[unitAmount] ;
		raceArray [1].GetComponent<Race> ().unitRange = new float[unitAmount];
		raceArray[1].GetComponent<Race>().unitMaxHealth = new float[unitAmount] ;
		raceArray[1].GetComponent<Race>().unitArmor = new float[unitAmount] ;
		raceArray[1].GetComponent<Race>().unitCooldown = new float[unitAmount] ;
		raceArray[1].GetComponent<Race>().unitSprite = new Sprite[unitAmount] ;
		
		raceArray [1].GetComponent<Race>().raceName = "Nedrex";
		raceArray [1].transform.name = "Nedrex";
		
		raceArray[1].GetComponent<Race>().unitName[0] = "Buzzgrunt" ;		
		raceArray [1].GetComponent<Race>().unitSpeed [0] = 1.1f; 	
		raceArray [1].GetComponent<Race>().unitAtkDelay [0] = 50f;	 
		raceArray [1].GetComponent<Race>().unitAtkDamage [0] = 2.5f;		
		raceArray [1].GetComponent<Race>().unitMaxHealth [0] = 150f;		
		raceArray [1].GetComponent<Race>().unitArmor [0] = 0f;	
		raceArray [1].GetComponent<Race>().unitSprite [0] = Resources.Load<Sprite> (raceArray [1].transform.name + "/0");
		raceArray [1].GetComponent<Race>().unitCooldown [0] = 2.6f;
		raceArray [1].GetComponent<Race>().unitRange [0] = 0.15f;	
		
		raceArray[1].GetComponent<Race>().unitName[1] = "Buzzdodger" ;		
		raceArray [1].GetComponent<Race>().unitSpeed [1] = 1.0f; 	
		raceArray [1].GetComponent<Race>().unitAtkDelay [1] = 80f;	 
		raceArray [1].GetComponent<Race>().unitAtkDamage [1] = 3.2f;		
		raceArray [1].GetComponent<Race>().unitMaxHealth [1] = 120f;	
		raceArray [1].GetComponent<Race>().unitArmor [1] = 0f;	
		raceArray [1].GetComponent<Race>().unitSprite [1] = Resources.Load<Sprite> (raceArray [1].transform.name + "/1");
		raceArray [1].GetComponent<Race>().unitCooldown [1] = 3.0f;	
		raceArray [1].GetComponent<Race>().unitRange [1] = 0.15f;	
		
		raceArray[1].GetComponent<Race>().unitName[2] = "Boomstick" ;		
		raceArray [1].GetComponent<Race>().unitSpeed [2] = 2.5f; 
		raceArray [1].GetComponent<Race>().unitAtkDelay [2] = 1000f;
		raceArray [1].GetComponent<Race>().unitAtkDamage [2] = 0f;			
		raceArray [1].GetComponent<Race>().unitMaxHealth [2] = 40f;			
		raceArray [1].GetComponent<Race>().unitArmor [2] = 2f;	
		raceArray [1].GetComponent<Race>().unitSprite [2] = Resources.Load<Sprite> (raceArray [1].transform.name + "/2");	
		raceArray [1].GetComponent<Race>().unitCooldown [2] = 2.2f;	
		raceArray [1].GetComponent<Race>().unitRange [2] = 0.05f;	
		
		raceArray[1].GetComponent<Race>().unitName[3] = "Junker" ;		 	 
		raceArray [1].GetComponent<Race>().unitSpeed [3] = 0.7f; 	
		raceArray [1].GetComponent<Race>().unitAtkDelay [3] = 500f; 
		raceArray [1].GetComponent<Race>().unitAtkDamage [3] = 12f;	
		raceArray [1].GetComponent<Race>().unitMaxHealth [3] = 130f;	
		raceArray [1].GetComponent<Race>().unitArmor [3] = 0f;
		raceArray [1].GetComponent<Race>().unitSprite [3] = Resources.Load<Sprite> (raceArray [1].transform.name + "/3");	
		raceArray [1].GetComponent<Race>().unitCooldown [3] = 3.0f;	
		raceArray [1].GetComponent<Race>().unitRange [3] = 0.4f;
		
		raceArray[1].GetComponent<Race>().unitName[4] = "Buckshooter" ;		
		raceArray [1].GetComponent<Race>().unitSpeed [4] = 0.8f; 
		raceArray [1].GetComponent<Race>().unitAtkDelay [4] = 1500f;
		raceArray [1].GetComponent<Race>().unitAtkDamage [4] = 140f;	
		raceArray [1].GetComponent<Race>().unitMaxHealth [4] = 200f;		
		raceArray [1].GetComponent<Race>().unitArmor [4] = 0f;	
		raceArray [1].GetComponent<Race>().unitSprite [4] = Resources.Load<Sprite> (raceArray [1].transform.name + "/4");
		raceArray [1].GetComponent<Race>().unitCooldown [4] = 4.0f;
		raceArray [1].GetComponent<Race>().unitRange [4] = 0.25f;		
		
		raceArray[1].GetComponent<Race>().unitName[5] = "SandBagger" ;		
		raceArray [1].GetComponent<Race>().unitSpeed [5] = 0.6f; 
		raceArray [1].GetComponent<Race>().unitAtkDelay [5] = 1000f;
		raceArray [1].GetComponent<Race>().unitAtkDamage [5] = 100f;	
		raceArray [1].GetComponent<Race>().unitMaxHealth [5] = 160f;		
		raceArray [1].GetComponent<Race>().unitArmor [5] = 0f;	
		raceArray [1].GetComponent<Race>().unitSprite [5] = Resources.Load<Sprite> (raceArray [1].transform.name + "/5");
		raceArray [1].GetComponent<Race>().unitCooldown [5] = 4.2f;
		raceArray [1].GetComponent<Race>().unitRange [5] = 0.48f;
		
		raceArray[1].GetComponent<Race>().unitName[6] = "SandBags" ;		
		raceArray [1].GetComponent<Race>().unitSpeed [6] = 0.0f; 
		raceArray [1].GetComponent<Race>().unitAtkDelay [6] = 1000f;
		raceArray [1].GetComponent<Race>().unitAtkDamage [6] = 0;	
		raceArray [1].GetComponent<Race>().unitMaxHealth [6] = 100f;		
		raceArray [1].GetComponent<Race>().unitArmor [6] = 1f;	
		raceArray [1].GetComponent<Race>().unitSprite [6] = Resources.Load<Sprite> (raceArray [1].transform.name + "/6");
		raceArray [1].GetComponent<Race>().unitCooldown [6] = 0.5f;
		raceArray [1].GetComponent<Race>().unitRange [6] = 0.1f;
		
		raceArray[1].GetComponent<Race>().unitName[7] = "Dozer" ;		
		raceArray [1].GetComponent<Race>().unitSpeed [7] = 1.2f; 
		raceArray [1].GetComponent<Race>().unitAtkDelay [7] = 1000f;
		raceArray [1].GetComponent<Race>().unitAtkDamage [7] = 22;	
		raceArray [1].GetComponent<Race>().unitMaxHealth [7] = 70f;		
		raceArray [1].GetComponent<Race>().unitArmor [7] = 0f;	
		raceArray [1].GetComponent<Race>().unitSprite [7] = Resources.Load<Sprite> (raceArray [1].transform.name + "/7");
		raceArray [1].GetComponent<Race>().unitCooldown [7] = 4.0f;
		raceArray [1].GetComponent<Race>().unitRange [7] = 0.2f;
		
		raceArray[1].GetComponent<Race>().unitName[8] = "Triple Boomstick" ;		
		raceArray [1].GetComponent<Race>().unitSpeed [8] = 2.5f; 
		raceArray [1].GetComponent<Race>().unitAtkDelay [8] = 1000f;
		raceArray [1].GetComponent<Race>().unitAtkDamage [8] = 0f;			
		raceArray [1].GetComponent<Race>().unitMaxHealth [8] = 40f;			
		raceArray [1].GetComponent<Race>().unitArmor [8] = 2f;	
		raceArray [1].GetComponent<Race>().unitSprite [8] = Resources.Load<Sprite> (raceArray [1].transform.name + "/2");	
		raceArray [1].GetComponent<Race>().unitCooldown [8] = 6.5f;	
		raceArray [1].GetComponent<Race>().unitRange [8] = 0.05f;	

		raceArray[1].GetComponent<Race>().unitName[9] = "Biggun" ;		
		raceArray [1].GetComponent<Race>().unitSpeed [9] = 0.2f; 
		raceArray [1].GetComponent<Race>().unitAtkDelay [9] = 800f;
		raceArray [1].GetComponent<Race>().unitAtkDamage [9] = 120f;			
		raceArray [1].GetComponent<Race>().unitMaxHealth [9] = 300f;			
		raceArray [1].GetComponent<Race>().unitArmor [9] = 3f;	
		raceArray [1].GetComponent<Race>().unitSprite [9] = Resources.Load<Sprite> (raceArray [1].transform.name + "/8");	
		raceArray [1].GetComponent<Race>().unitCooldown [9] = 6f;	
		raceArray [1].GetComponent<Race>().unitRange [9] = 0.4f;	
	}
	//int fps = Mathf.RoundToInt(1.0f/Time.deltaTime) ;
}
