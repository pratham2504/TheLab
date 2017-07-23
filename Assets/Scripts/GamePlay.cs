using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlay : MonoBehaviour {

	//public Button pourVinegar;
	public Animator pourVinegar;
	//public Button pourBS;
	//public Button pourSoap;

	//public GameObject Vinegar;
	//public GameObject BS;
	//public GameObject Soap;

	// Use this for initialization
	void Start () {

		pourVinegar = GetComponent<Animator>();	
	}
	
	// Update is called once per frame
	void Update () {

		//declare a new RayCastHit
		RaycastHit hit;

		if (Physics.Raycast (gameObject.transform.position, gameObject.transform.forward, out hit, 25)) {

			if (hit.collider.name.Contains ("Button")) {

				pourVinegar.SetTrigger("PourBottle");

				//Vinegar.GetComponent<Animation> ().Play ();
				//pourVinegar.GetComponent<Animation> ().Stop ();
			}
		}

	}
}
