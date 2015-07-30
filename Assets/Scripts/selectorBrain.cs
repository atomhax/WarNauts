using UnityEngine;
using System.Collections;

public class selectorBrain : MonoBehaviour {

	public globalVariables variables ; 
	public GameObject race ;
	public GameObject preview1 ;
	public int playerAxis ;
	GameObject preview ;
	public GameObject bigPreview ;
	public GameObject border ;
	GameObject selectedBorder ;
	public int currentlySelected ;
	public globalFunctions functions ;
	int[] unitBank ;
	int row ;

	public string rInput;
	public string lInput;
	float RTriggerInput;
	float LTriggerInput;
	float selectCooldown;

	//local references to Arrows
	public UnitCreator Creator;


	// Use this for initialization
	void Start () {
		currentlySelected = 0;

		race = variables.raceArray[(int)Mathf.Floor(Random.value*variables.raceAmount)] ;
		unitBank = new int[race.GetComponent<Race>().unitAmount] ;
		for(int i=0 ; i< unitBank.Length ; i+=1)
		{
			preview = (GameObject) Instantiate(preview1) ;
			preview.GetComponent<SpriteRenderer>().sprite = race.GetComponent<Race>().unitSprite[i] ;
			preview.transform.parent = transform ;
			preview.transform.localPosition = new Vector3((i*0.42f) - (Mathf.Floor(i/10f)*4.2f)-1.85f,(-1*(Mathf.Floor(i/10f))*0.42f)+2.48f,0f) ;

			//unitBank[i] = current;
		}
		selectedBorder = Instantiate (border) ;
		selectedBorder.transform.parent = transform ;
		selectCooldown = 0;

		bigPreview = (GameObject) Instantiate(preview1) ;
		bigPreview.GetComponent<SpriteRenderer>().sprite = race.GetComponent<Race>().unitSprite[currentlySelected] ;
		bigPreview.transform.parent = transform ;
		bigPreview.transform.localPosition = new Vector3(1.2f,0.9f,0f) ;
		bigPreview.transform.localScale = new Vector3(variables.previewScale,variables.previewScale,variables.previewScale) ;

		Creator.selector = gameObject.GetComponent<selectorBrain>();
		Creator.race = race;
		//race = null;
	}
	
	// Update is called once per frame
	void Update () {
		RTriggerInput = Input.GetAxis (rInput);
		LTriggerInput = Input.GetAxis (lInput);
		selectCooldown -= Time.deltaTime;
		if (Mathf.Abs (LTriggerInput - RTriggerInput) > 0.5f && selectCooldown <= 0) {
			currentlySelected += Mathf.RoundToInt(LTriggerInput - RTriggerInput);
			currentlySelected  = functions.wrapOver(currentlySelected,unitBank.Length-1,0) ;//(int) Mathf.Clamp(currentRow,-8f,8f) ;

			selectCooldown = variables.baseCooldown;

			bigPreview.GetComponent<SpriteRenderer>().sprite = race.GetComponent<Race>().unitSprite[currentlySelected] ;
			bigPreview.transform.parent = transform ;
			bigPreview.transform.localPosition = new Vector3(1.2f,0.9f,0f) ;
			bigPreview.transform.localScale = new Vector3(variables.previewScale,variables.previewScale,variables.previewScale) ;
		}

		selectedBorder.transform.localPosition = new Vector3 ((currentlySelected*0.42f) - (Mathf.Floor(currentlySelected/10f)*4.2f)-1.89f,(-1*(Mathf.Floor(currentlySelected/10f))*0.42f)+2.48f,0f) ;
	}
}
