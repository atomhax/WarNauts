using UnityEngine;
using System.Collections;

public class globalFunctions : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame

	public int wrapOver(int number, int upper, int lower) {
		if (number > upper) {
			return lower ;
		} else if (number < lower) {
			return upper ;
		} else {
			return number ;
		}
	}
	
}
