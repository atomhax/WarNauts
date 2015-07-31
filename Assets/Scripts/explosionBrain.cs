using UnityEngine;
using System.Collections;

public class explosionBrain : MonoBehaviour {
	public float explosionSize ;
	public float explosionDamage;
	public float explosionTime;

	float currentSize ;

	// Use this for initialization
	void Start () {
		transform.localScale = new Vector3 (0f, 0f, 0f);
		//Time.timeScale = 0;
	}
	
	// Update is called once per frame
	void Update () {
		transform.localScale = new Vector3 (currentSize/explosionSize,currentSize/explosionSize,0f);
		currentSize += Time.deltaTime/explosionTime;
		if (currentSize >= explosionSize) {
			Destroy(gameObject) ;
		}
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.GetComponent<colliderBrain> ().type == 0) {
			other.gameObject.GetComponent<UnitBrain> ().currentHealth -= explosionDamage;
		}
	}
}
