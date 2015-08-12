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
	int raceNum ;
	int unitNum ;
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
		raceNum = 0;
		unitNum = 0;
		raceArray [raceNum].GetComponent<Race>().unitAmount = unitAmount ;
		
		raceArray[raceNum].GetComponent<Race>().unitName = new string[unitAmount] ;
		raceArray[raceNum].GetComponent<Race>().unitSpeed = new float[unitAmount] ;
		raceArray[raceNum].GetComponent<Race>().unitAtkDelay = new float[unitAmount] ;
		raceArray[raceNum].GetComponent<Race>().unitAtkDamage = new float[unitAmount] ;
		raceArray[raceNum].GetComponent<Race> ().unitRange = new float[unitAmount];
		raceArray[raceNum].GetComponent<Race>().unitMaxHealth = new float[unitAmount] ;
		raceArray[raceNum].GetComponent<Race>().unitArmor = new float[unitAmount] ;
		raceArray[raceNum].GetComponent<Race>().unitCooldown = new float[unitAmount] ;
		raceArray[raceNum].GetComponent<Race>().unitSprite = new Sprite[unitAmount] ;
		raceArray[raceNum].GetComponent<Race>().unitPlayerDamage = new float[unitAmount] ;
		
		
		
		raceArray[raceNum].GetComponent<Race>().raceName = "Chronowarpers";
		raceArray[raceNum].transform.name = raceArray[raceNum].GetComponent<Race>().raceName;

		raceArray[raceNum].GetComponent<Race>().unitName[unitNum] = "Moment" ;
		raceArray[raceNum].GetComponent<Race>().unitSpeed [unitNum] = 0.8f; 	
		raceArray[raceNum].GetComponent<Race>().unitAtkDelay [unitNum] = 1000f;	
		raceArray[raceNum].GetComponent<Race>().unitAtkDamage [unitNum] = 20f;		
		raceArray[raceNum].GetComponent<Race>().unitMaxHealth [unitNum] = 140f;		
		raceArray[raceNum].GetComponent<Race>().unitArmor [unitNum] = 0f;	
		raceArray[raceNum].GetComponent<Race>().unitSprite [unitNum] = Resources.Load<Sprite> (raceArray[raceNum].transform.name + "/0");	
		raceArray[raceNum].GetComponent<Race>().unitCooldown [unitNum] = 2.2f;	
		raceArray[raceNum].GetComponent<Race>().unitRange [unitNum] = 0.87f;
		raceArray[raceNum].GetComponent<Race>().unitPlayerDamage [unitNum] = 10f;
		unitNum++;
		
		raceArray[raceNum].GetComponent<Race>().unitName[unitNum] = "Jiffy" ;		 
		raceArray[raceNum].GetComponent<Race>().unitSpeed [unitNum] = 1.2f; 	
		raceArray[raceNum].GetComponent<Race>().unitAtkDelay [unitNum] = 500f;		
		raceArray[raceNum].GetComponent<Race>().unitAtkDamage [unitNum] = 10f;		
		raceArray[raceNum].GetComponent<Race>().unitMaxHealth [unitNum] = 150f;		
		raceArray[raceNum].GetComponent<Race>().unitArmor [unitNum] = 0f;	
		raceArray[raceNum].GetComponent<Race>().unitSprite [unitNum] = Resources.Load<Sprite> (raceArray[raceNum].transform.name + "/1");	
		raceArray[raceNum].GetComponent<Race>().unitCooldown [unitNum] = 3.0f; 
		raceArray[raceNum].GetComponent<Race>().unitRange [unitNum] = 1.0f;	
		raceArray[raceNum].GetComponent<Race>().unitPlayerDamage [unitNum] = 10f;
		unitNum++;
		
		raceArray[raceNum].GetComponent<Race>().unitName[unitNum] = "Century" ;		 
		raceArray[raceNum].GetComponent<Race>().unitSpeed [unitNum] = 0.3f; 	
		raceArray[raceNum].GetComponent<Race>().unitAtkDelay [unitNum] = 100f;		
		raceArray[raceNum].GetComponent<Race>().unitAtkDamage [unitNum] = 5.5f;	
		raceArray[raceNum].GetComponent<Race>().unitMaxHealth [unitNum] = 350f;		
		raceArray[raceNum].GetComponent<Race>().unitArmor [unitNum] = 3f;	
		raceArray[raceNum].GetComponent<Race>().unitSprite [unitNum] = Resources.Load<Sprite> (raceArray[raceNum].transform.name + "/2");	
		raceArray[raceNum].GetComponent<Race>().unitCooldown [unitNum] = 4.0f; 
		raceArray[raceNum].GetComponent<Race>().unitRange [unitNum] = 0.5f;	
		raceArray[raceNum].GetComponent<Race>().unitPlayerDamage [unitNum] = 10f;
		unitNum++;
		
		raceArray[raceNum].GetComponent<Race>().unitName[unitNum] = "Eon" ;		 	
		raceArray[raceNum].GetComponent<Race>().unitSpeed [unitNum] = 0.35f;	
		raceArray[raceNum].GetComponent<Race>().unitAtkDelay [unitNum] = 4200f;	
		raceArray[raceNum].GetComponent<Race>().unitAtkDamage [unitNum] = 100f;	
		raceArray[raceNum].GetComponent<Race>().unitMaxHealth [unitNum] = 100f;		
		raceArray[raceNum].GetComponent<Race>().unitArmor [unitNum] = 2f;	
		raceArray[raceNum].GetComponent<Race>().unitSprite [unitNum] = Resources.Load<Sprite> (raceArray[raceNum].transform.name + "/3");	
		raceArray[raceNum].GetComponent<Race>().unitCooldown [unitNum] = 5.0f; 
		raceArray[raceNum].GetComponent<Race>().unitRange [unitNum] = 3.6f;	
		raceArray[raceNum].GetComponent<Race>().unitPlayerDamage [unitNum] = 10f;
		unitNum++;
		
		raceArray[raceNum].GetComponent<Race>().unitName[unitNum] = "Leap Year" ;	 
		raceArray[raceNum].GetComponent<Race>().unitSpeed [unitNum] = 0.25f;	
		raceArray[raceNum].GetComponent<Race>().unitAtkDelay [unitNum] = 400f;		
		raceArray[raceNum].GetComponent<Race>().unitAtkDamage [unitNum] = 20f;		
		raceArray[raceNum].GetComponent<Race>().unitMaxHealth [unitNum] = 160f;		
		raceArray[raceNum].GetComponent<Race>().unitArmor [unitNum] = 3f;	
		raceArray[raceNum].GetComponent<Race>().unitSprite [unitNum] = Resources.Load<Sprite> (raceArray[raceNum].transform.name + "/4");	
		raceArray[raceNum].GetComponent<Race>().unitCooldown [unitNum] = 3.7f; 
		raceArray[raceNum].GetComponent<Race>().unitRange [unitNum] = 0.9f;
		raceArray[raceNum].GetComponent<Race>().unitPlayerDamage [unitNum] = 10f;
		unitNum++;
		
		raceArray[raceNum].GetComponent<Race>().unitName[unitNum] = "NanoSecond" ;	
		raceArray[raceNum].GetComponent<Race>().unitSpeed [unitNum] = 0.9f;	
		raceArray[raceNum].GetComponent<Race>().unitAtkDelay [unitNum] = 600f;		
		raceArray[raceNum].GetComponent<Race>().unitAtkDamage [unitNum] = 10f;		
		raceArray[raceNum].GetComponent<Race>().unitMaxHealth [unitNum] = 80f;			
		raceArray[raceNum].GetComponent<Race>().unitArmor [unitNum] = 0f;	
		raceArray[raceNum].GetComponent<Race>().unitSprite [unitNum] = Resources.Load<Sprite> (raceArray[raceNum].transform.name + "/5");	
		raceArray[raceNum].GetComponent<Race>().unitCooldown [unitNum] = 2.8f; 
		raceArray[raceNum].GetComponent<Race>().unitRange [unitNum] = 0.4f;
		raceArray[raceNum].GetComponent<Race>().unitPlayerDamage [unitNum] = 10f;
		unitNum++;
		
		raceArray[raceNum].GetComponent<Race>().unitName[unitNum] = "Lifetime" ;	 
		raceArray[raceNum].GetComponent<Race>().unitSpeed [unitNum] = 0.6f;	
		raceArray[raceNum].GetComponent<Race>().unitAtkDelay [unitNum] = 1700f;	
		raceArray[raceNum].GetComponent<Race>().unitAtkDamage [unitNum] = 20f;		
		raceArray[raceNum].GetComponent<Race>().unitMaxHealth [unitNum] = 220f;		
		raceArray[raceNum].GetComponent<Race>().unitArmor [unitNum] = 0f;	
		raceArray[raceNum].GetComponent<Race>().unitSprite [unitNum] = Resources.Load<Sprite> (raceArray[raceNum].transform.name + "/6");	
		raceArray[raceNum].GetComponent<Race>().unitCooldown [unitNum] = 3.7f; 
		raceArray[raceNum].GetComponent<Race>().unitRange [unitNum] = 1.1f;
		raceArray[raceNum].GetComponent<Race>().unitPlayerDamage [unitNum] = 10f;
		unitNum++;
		
		raceArray[raceNum].GetComponent<Race>().unitName[unitNum] = "Meridian" ;	 
		raceArray[raceNum].GetComponent<Race>().unitSpeed [unitNum] = 1.0f;	
		raceArray[raceNum].GetComponent<Race>().unitAtkDelay [unitNum] = 1000f;	
		raceArray[raceNum].GetComponent<Race>().unitAtkDamage [unitNum] = 20f;		
		raceArray[raceNum].GetComponent<Race>().unitMaxHealth [unitNum] = 420f;		
		raceArray[raceNum].GetComponent<Race>().unitArmor [unitNum] = 4f;	
		raceArray[raceNum].GetComponent<Race>().unitSprite [unitNum] = Resources.Load<Sprite> (raceArray[raceNum].transform.name + "/7");	
		raceArray[raceNum].GetComponent<Race>().unitCooldown [unitNum] = 6.5f; 
		raceArray[raceNum].GetComponent<Race>().unitRange [unitNum] = 0.8f;
		raceArray[raceNum].GetComponent<Race>().unitPlayerDamage [unitNum] = 10f;
		unitNum++;
		
		raceArray[raceNum].GetComponent<Race>().unitName[unitNum] = "Millenium" ;	 
		raceArray[raceNum].GetComponent<Race>().unitSpeed [unitNum] = 0.1f;	
		raceArray[raceNum].GetComponent<Race>().unitAtkDelay [unitNum] = 60f;		
		raceArray[raceNum].GetComponent<Race>().unitAtkDamage [unitNum] = 5f;		
		raceArray[raceNum].GetComponent<Race>().unitMaxHealth [unitNum] = 700f;	
		raceArray[raceNum].GetComponent<Race>().unitArmor [unitNum] = 6f;	
		raceArray[raceNum].GetComponent<Race>().unitSprite [unitNum] = Resources.Load<Sprite> (raceArray[raceNum].transform.name + "/8");
		raceArray[raceNum].GetComponent<Race>().unitCooldown [unitNum] = 10f;
		raceArray[raceNum].GetComponent<Race>().unitRange [unitNum] = 0.6f;
		raceArray[raceNum].GetComponent<Race>().unitPlayerDamage [unitNum] = 10f;


		//Nedrex start
		unitAmount = 10;
		raceNum++;
		unitNum = 0;
		raceArray[raceNum].GetComponent<Race>().unitAmount = unitAmount ;
		
		raceArray[raceNum].GetComponent<Race>().unitName = new string[unitAmount] ;
		raceArray[raceNum].GetComponent<Race>().unitSpeed = new float[unitAmount] ;
		raceArray[raceNum].GetComponent<Race>().unitAtkDelay = new float[unitAmount] ;
		raceArray[raceNum].GetComponent<Race>().unitAtkDamage = new float[unitAmount] ;
		raceArray[raceNum].GetComponent<Race> ().unitRange = new float[unitAmount];
		raceArray[raceNum].GetComponent<Race>().unitMaxHealth = new float[unitAmount] ;
		raceArray[raceNum].GetComponent<Race>().unitArmor = new float[unitAmount] ;
		raceArray[raceNum].GetComponent<Race>().unitCooldown = new float[unitAmount] ;
		raceArray[raceNum].GetComponent<Race>().unitSprite = new Sprite[unitAmount] ;
		raceArray[raceNum].GetComponent<Race>().unitPlayerDamage = new float[unitAmount] ;
		
		raceArray[raceNum].GetComponent<Race>().raceName = "Nedrex";
		raceArray[raceNum].transform.name = "Nedrex";
		
		raceArray[raceNum].GetComponent<Race>().unitName[unitNum] = "Buzzgrunt" ;		
		raceArray[raceNum].GetComponent<Race>().unitSpeed [unitNum] = 1.1f; 	
		raceArray[raceNum].GetComponent<Race>().unitAtkDelay [unitNum] = 50f;	 
		raceArray[raceNum].GetComponent<Race>().unitAtkDamage [unitNum] = 2.5f;		
		raceArray[raceNum].GetComponent<Race>().unitMaxHealth [unitNum] = 150f;		
		raceArray[raceNum].GetComponent<Race>().unitArmor [unitNum] = 0f;	
		raceArray[raceNum].GetComponent<Race>().unitSprite [unitNum] = Resources.Load<Sprite> (raceArray[raceNum].transform.name + "/0");
		raceArray[raceNum].GetComponent<Race>().unitCooldown [unitNum] = 2.6f;
		raceArray[raceNum].GetComponent<Race>().unitRange [unitNum] = 0.15f;
		raceArray[raceNum].GetComponent<Race>().unitPlayerDamage [unitNum] = 10f;	
		unitNum++;
		
		raceArray[raceNum].GetComponent<Race>().unitName[unitNum] = "Buzzdodger" ;		
		raceArray[raceNum].GetComponent<Race>().unitSpeed [unitNum] = 1.0f; 	
		raceArray[raceNum].GetComponent<Race>().unitAtkDelay [unitNum] = 80f;	 
		raceArray[raceNum].GetComponent<Race>().unitAtkDamage [unitNum] = 3.2f;		
		raceArray[raceNum].GetComponent<Race>().unitMaxHealth [unitNum] = 120f;	
		raceArray[raceNum].GetComponent<Race>().unitArmor [unitNum] = 0f;	
		raceArray[raceNum].GetComponent<Race>().unitSprite [unitNum] = Resources.Load<Sprite> (raceArray[raceNum].transform.name + "/1");
		raceArray[raceNum].GetComponent<Race>().unitCooldown [unitNum] = 3.0f;	
		raceArray[raceNum].GetComponent<Race>().unitRange [unitNum] = 0.15f;	
		raceArray[raceNum].GetComponent<Race>().unitPlayerDamage [unitNum] = 10f;
		unitNum++;
		
		raceArray[raceNum].GetComponent<Race>().unitName[unitNum] = "Boomstick" ;		
		raceArray[raceNum].GetComponent<Race>().unitSpeed [unitNum] = 2.5f; 
		raceArray[raceNum].GetComponent<Race>().unitAtkDelay [unitNum] = 1000f;
		raceArray[raceNum].GetComponent<Race>().unitAtkDamage [unitNum] = 0f;			
		raceArray[raceNum].GetComponent<Race>().unitMaxHealth [unitNum] = 40f;			
		raceArray[raceNum].GetComponent<Race>().unitArmor [unitNum] = 2f;	
		raceArray[raceNum].GetComponent<Race>().unitSprite [unitNum] = Resources.Load<Sprite> (raceArray[raceNum].transform.name + "/2");	
		raceArray[raceNum].GetComponent<Race>().unitCooldown [unitNum] = 2.2f;	
		raceArray[raceNum].GetComponent<Race>().unitRange [unitNum] = 0.05f;	
		raceArray[raceNum].GetComponent<Race>().unitPlayerDamage [unitNum] = 10f;
		unitNum++;
		
		raceArray[raceNum].GetComponent<Race>().unitName[unitNum] = "Junker" ;		 	 
		raceArray[raceNum].GetComponent<Race>().unitSpeed [unitNum] = 0.7f; 	
		raceArray[raceNum].GetComponent<Race>().unitAtkDelay [unitNum] = 500f; 
		raceArray[raceNum].GetComponent<Race>().unitAtkDamage [unitNum] = 12f;	
		raceArray[raceNum].GetComponent<Race>().unitMaxHealth [unitNum] = 130f;	
		raceArray[raceNum].GetComponent<Race>().unitArmor [unitNum] = 0f;
		raceArray[raceNum].GetComponent<Race>().unitSprite [unitNum] = Resources.Load<Sprite> (raceArray[raceNum].transform.name + "/3");	
		raceArray[raceNum].GetComponent<Race>().unitCooldown [unitNum] = 3.0f;	
		raceArray[raceNum].GetComponent<Race>().unitRange [unitNum] = 0.4f;
		raceArray[raceNum].GetComponent<Race>().unitPlayerDamage [unitNum] = 10f;
		unitNum++;
		
		raceArray[raceNum].GetComponent<Race>().unitName[unitNum] = "Buckshooter" ;		
		raceArray[raceNum].GetComponent<Race>().unitSpeed [unitNum] = 0.8f; 
		raceArray[raceNum].GetComponent<Race>().unitAtkDelay [unitNum] = 1500f;
		raceArray[raceNum].GetComponent<Race>().unitAtkDamage [unitNum] = 140f;	
		raceArray[raceNum].GetComponent<Race>().unitMaxHealth [unitNum] = 200f;		
		raceArray[raceNum].GetComponent<Race>().unitArmor [unitNum] = 0f;	
		raceArray[raceNum].GetComponent<Race>().unitSprite [unitNum] = Resources.Load<Sprite> (raceArray[raceNum].transform.name + "/4");
		raceArray[raceNum].GetComponent<Race>().unitCooldown [unitNum] = 4.0f;
		raceArray[raceNum].GetComponent<Race>().unitRange [unitNum] = 0.25f;
		raceArray[raceNum].GetComponent<Race>().unitPlayerDamage [unitNum] = 10f;		
		unitNum++;
		
		raceArray[raceNum].GetComponent<Race>().unitName[unitNum] = "SandBagger" ;		
		raceArray[raceNum].GetComponent<Race>().unitSpeed [unitNum] = 0.6f; 
		raceArray[raceNum].GetComponent<Race>().unitAtkDelay [unitNum] = 1000f;
		raceArray[raceNum].GetComponent<Race>().unitAtkDamage [unitNum] = 100f;	
		raceArray[raceNum].GetComponent<Race>().unitMaxHealth [unitNum] = 160f;		
		raceArray[raceNum].GetComponent<Race>().unitArmor [unitNum] = 0f;	
		raceArray[raceNum].GetComponent<Race>().unitSprite [unitNum] = Resources.Load<Sprite> (raceArray[raceNum].transform.name + "/5");
		raceArray[raceNum].GetComponent<Race>().unitCooldown [unitNum] = 4.2f;
		raceArray[raceNum].GetComponent<Race>().unitRange [unitNum] = 0.48f;
		raceArray[raceNum].GetComponent<Race>().unitPlayerDamage [unitNum] = 10f;
		unitNum++;
		
		raceArray[raceNum].GetComponent<Race>().unitName[unitNum] = "SandBags" ;		
		raceArray[raceNum].GetComponent<Race>().unitSpeed [unitNum] = 0.0f; 
		raceArray[raceNum].GetComponent<Race>().unitAtkDelay [unitNum] = 1000f;
		raceArray[raceNum].GetComponent<Race>().unitAtkDamage [unitNum] = 0;	
		raceArray[raceNum].GetComponent<Race>().unitMaxHealth [unitNum] = 100f;		
		raceArray[raceNum].GetComponent<Race>().unitArmor [unitNum] = 1f;	
		raceArray[raceNum].GetComponent<Race>().unitSprite [unitNum] = Resources.Load<Sprite> (raceArray[raceNum].transform.name + "/6");
		raceArray[raceNum].GetComponent<Race>().unitCooldown [unitNum] = 0.5f;
		raceArray[raceNum].GetComponent<Race>().unitRange [unitNum] = 0.1f;
		raceArray[raceNum].GetComponent<Race>().unitPlayerDamage [unitNum] = 10f;
		unitNum++;
		
		raceArray[raceNum].GetComponent<Race>().unitName[unitNum] = "Dozer" ;		
		raceArray[raceNum].GetComponent<Race>().unitSpeed [unitNum] = 1.2f; 
		raceArray[raceNum].GetComponent<Race>().unitAtkDelay [unitNum] = 1000f;
		raceArray[raceNum].GetComponent<Race>().unitAtkDamage [unitNum] = 22;	
		raceArray[raceNum].GetComponent<Race>().unitMaxHealth [unitNum] = 70f;		
		raceArray[raceNum].GetComponent<Race>().unitArmor [unitNum] = 0f;	
		raceArray[raceNum].GetComponent<Race>().unitSprite [unitNum] = Resources.Load<Sprite> (raceArray[raceNum].transform.name + "/7");
		raceArray[raceNum].GetComponent<Race>().unitCooldown [unitNum] = 4.0f;
		raceArray[raceNum].GetComponent<Race>().unitRange [unitNum] = 0.2f;
		raceArray[raceNum].GetComponent<Race>().unitPlayerDamage [unitNum] = 10f;
		unitNum++;
		
		raceArray[raceNum].GetComponent<Race>().unitName[unitNum] = "Triple Boomstick" ;		
		raceArray[raceNum].GetComponent<Race>().unitSpeed [unitNum] = 2.5f; 
		raceArray[raceNum].GetComponent<Race>().unitAtkDelay [unitNum] = 1000f;
		raceArray[raceNum].GetComponent<Race>().unitAtkDamage [unitNum] = 0f;			
		raceArray[raceNum].GetComponent<Race>().unitMaxHealth [unitNum] = 40f;			
		raceArray[raceNum].GetComponent<Race>().unitArmor [unitNum] = 2f;	
		raceArray[raceNum].GetComponent<Race>().unitSprite [unitNum] = Resources.Load<Sprite> (raceArray[raceNum].transform.name + "/2");	
		raceArray[raceNum].GetComponent<Race>().unitCooldown [unitNum] = 6.5f;	
		raceArray[raceNum].GetComponent<Race>().unitRange [unitNum] = 0.05f;	
		raceArray[raceNum].GetComponent<Race>().unitPlayerDamage [unitNum] = 10f;
		unitNum++;

		raceArray[raceNum].GetComponent<Race>().unitName[unitNum] = "Biggun" ;		
		raceArray[raceNum].GetComponent<Race>().unitSpeed [unitNum] = 0.2f; 
		raceArray[raceNum].GetComponent<Race>().unitAtkDelay [unitNum] = 800f;
		raceArray[raceNum].GetComponent<Race>().unitAtkDamage [unitNum] = 120f;			
		raceArray[raceNum].GetComponent<Race>().unitMaxHealth [unitNum] = 300f;			
		raceArray[raceNum].GetComponent<Race>().unitArmor [unitNum] = 3f;	
		raceArray[raceNum].GetComponent<Race>().unitSprite [unitNum] = Resources.Load<Sprite> (raceArray[raceNum].transform.name + "/8");	
		raceArray[raceNum].GetComponent<Race>().unitCooldown [unitNum] = 6f;	
		raceArray[raceNum].GetComponent<Race>().unitRange [unitNum] = 0.4f;	
		raceArray[raceNum].GetComponent<Race>().unitPlayerDamage [unitNum] = 10f;
	}
	//int fps = Mathf.RoundToInt(1.0f/Time.deltaTime) ;
}
