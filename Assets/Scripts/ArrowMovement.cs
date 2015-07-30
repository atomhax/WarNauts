using UnityEngine;
using System.Collections;

public class ArrowMovement : MonoBehaviour {

	public int currentRow = 0 ;
	public string input ; 
	public short axis ;
	int cooldown = 0 ;//Mathf.RoundToInt((1/Time.deltaTime)*globalVariables.baseCooldown) ;
	public globalFunctions functions ;  
	public globalVariables variables ; 


	void Start() {
		if (axis % 2 != 0) {
			transform.Rotate(new Vector3 (0,0,(axis - 2) * 90f)) ;
		}

	}
	// Update is called once per frame
	void Update () {

		float verticalInput = Input.GetAxis(input);
		cooldown--;
		if (Mathf.Abs (verticalInput) > 0.3) {
			if (cooldown <= 0) {
				cooldown = Mathf.RoundToInt ((1 / Time.deltaTime) * variables.baseCooldown);
				//|transform.Translate (new Vector3 (0,Mathf.Sign(verticalInput) * globalVariables.rowHeight, 0));
					currentRow += (int) Mathf.Sign(verticalInput) ;
					currentRow  = functions.wrapOver(currentRow,8,-8) ;//(int) Mathf.Clamp(currentRow,-8f,8f) ;
				}
		}

		if (axis==0) {
			transform.position = (new Vector3 (5.06f,currentRow *variables.rowHeight, 0));
			transform.localScale = new Vector3(-1,1,1) ;
		} else if (axis==1){
			transform.position = (new Vector3 (currentRow *variables.rowHeight,5.06f, 0));
		}else if (axis==2){
			transform.position = (new Vector3 (-5.06f,currentRow *variables.rowHeight, 0));
			transform.localScale = new Vector3(1,1,1) ;
		} else if (axis==3){
			transform.position = (new Vector3 (currentRow *variables.rowHeight,-5.06f, 0));
		}

		
	}
}
