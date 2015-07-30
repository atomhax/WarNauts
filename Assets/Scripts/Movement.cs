using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float baseSpeed ;
	public int player ;


	// Use this for initialization
	void Start () {

		//Debug.Log (string.Concat ("Horizontal", player.ToString ()));

	}

	void FixedUpdate () {
		// (Input.GetAxis ("Horizontal") > 0) {
		transform.Translate(new Vector3(Input.GetAxis(string.Concat("HorizontalR",player.ToString()))*baseSpeed,Input.GetAxis(string.Concat("VerticalR",player.ToString()))*baseSpeed,0)) ; 
		//
	}
}
