using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

  public static Player S;


  public PlayerMovement PM;
  public PlayerInput PI;

	// Use this for initialization
	void Start () {
    S = this;

    PM = GetComponent<PlayerMovement>();
    PI = GetComponent<PlayerInput>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
