using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour {

  static readonly KeyCode right = KeyCode.RightArrow;
  static readonly KeyCode D = KeyCode.D;

  static readonly KeyCode left = KeyCode.LeftArrow;
  static readonly KeyCode A = KeyCode.A;

	// Update is called once per frame
	void Update () {
  
	  if (Input.GetKeyDown(right) || Input.GetKeyUp(D)) {
      Player.S.PM.SwitchLanes(Utils.Movement.Right);
    } 

    if (Input.GetKeyDown(left) || Input.GetKeyUp(A)) {
      Player.S.PM.SwitchLanes(Utils.Movement.Left);
    }
	}
}
