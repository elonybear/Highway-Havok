using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour {

  KeyCode right = KeyCode.RightArrow;
  KeyCode D = KeyCode.D;

  KeyCode left = KeyCode.LeftArrow;
  KeyCode A = KeyCode.A;

	// Update is called once per frame
	void Update () {
  
	  if (Input.GetKeyDown(right) || Input.GetKeyUp(D)) {
      Player.S.PM.SwitchLanes(Utils.Movement.Right);
    } 

    if (Input.GetKeyDown(left) || Input.GetKeyUp(A)) {
      Player.S.PM.SwitchLanes(Utils.Movement.Left);
    }

    if (Input.GetKeyDown(KeyCode.Space)) {
      Player.S.PM.Jump();
    }
	}
}
