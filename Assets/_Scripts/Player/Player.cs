using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

  public static Player S;


  public PlayerMovement PM;
  public PlayerInput PI;
  public PlayerAnimation PA;

	// Use this for initialization
	void Awake () {
    S = this;

    PM = GetComponent<PlayerMovement>();
    PI = GetComponent<PlayerInput>();
    PA = GetComponent<PlayerAnimation>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
