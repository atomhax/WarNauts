using UnityEngine;
using System.Collections;

public class NedrexGimmick : MonoBehaviour {
	
	bool canTele;
	GameObject explo ;
	UnitBrain unitBrain;
	
	// Use this for initialization
	void Start () {
		unitBrain = GetComponent<UnitBrain> ();
		transform.Rotate(new Vector3(0f,0f,(Random.value*10f)-5f)) ; //me.transform.rotation.eulerAngles.z
	}
	
	// Update is called once per frame
	void Update () {
		if (unitBrain.currentHealth <0) {
				explo = Instantiate(Resources.Load<GameObject>("explosion")) ;
				explo.GetComponent<explosionBrain>().explosionDamage = 50f ;
				explo.GetComponent<explosionBrain>().explosionSize = 0.14f ;
				explo.GetComponent<explosionBrain>().explosionTime = 0.4f ;
				explo.transform.position = transform.position ;
		}
	}
}