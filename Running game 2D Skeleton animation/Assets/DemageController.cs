using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemageController : MonoBehaviour
{
	public GameObject runner;
	

	void OnTriggerEnter2D(Collider2D col){
		if(col.CompareTag("Player")){
			Damage();
		}
	}

	void Damage(){
		runner.SetActive(false);
	}
	
}
