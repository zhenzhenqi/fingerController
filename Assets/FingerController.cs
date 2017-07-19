using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FingerController : MonoBehaviour {

	Animator fingerAnimator;

	// Use this for initialization
	void Start () {
		fingerAnimator = GetComponent <Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		fingerAnimator.SetFloat ("speed",  Mathf.Abs((  Input.GetAxis ("Vertical") + Mathf.Abs (Input.GetAxis ("Horizontal")) ))*1.2f, 0.2f, Time.deltaTime);



	

		
	}
}
