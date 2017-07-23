using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bottleAnimScript : MonoBehaviour {

	public Animator anim;

	public Button Button1;
	public Button Button2;
	public GameObject PouringParticles;

	//private float Timer=3;


	void Start() {
		anim = GetComponent<Animator>();
	}


	public void pour () {
		//Timer -= Time.deltaTime;
		anim.SetTrigger("PourBottle");
		Button1.animator.SetTrigger ("Diffuse");
		Button2.animator.SetTrigger ("Glow");
		PouringParticles.SetActive (true);
	}
	/*
	void Update(){
		if (transform.eulerAngles.y >= 90 && transform.eulerAngles <= -90) {
			PouringParticles.SetActive(true);
		}
		else {
			PouringParticles.SetActive(false);
		}
	}
	*/
}
