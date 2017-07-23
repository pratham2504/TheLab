using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonScript : MonoBehaviour {

	public Animator anim;

	public GameObject particleVinegar;
	public GameObject particleBS;
	public GameObject particleSoap;
	public GameObject particleLava;

	public GameObject RestartMenu;

	private float Timer = 12;

	// Use this for initialization
	void Start () {
		
	}

	public void ButtonAction(){
		anim.SetTrigger("BottleForward");
		GetComponent<Image>().color = Color.green;
	}
	
	// Update is called once per frame
	void Update () {
		if (Timer <= 0) {
			Timer = 0;
			RestartMenu.SetActive (true);
		}

		if (Timer <= 7) {
			particleLava.SetActive (true);
		}

		if (particleVinegar.activeSelf && particleBS.activeSelf && particleSoap.activeSelf) {
			Timer -= Time.deltaTime;
		}
	}
}
