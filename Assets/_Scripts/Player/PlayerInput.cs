using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour {

  static readonly KeyCode right = KeyCode.RightArrow;
  static readonly KeyCode D = KeyCode.D;

  static readonly KeyCode left = KeyCode.LeftArrow;
  static readonly KeyCode A = KeyCode.A;

  static readonly KeyCode up = KeyCode.UpArrow;
  static readonly KeyCode W = KeyCode.W;

  static readonly KeyCode down = KeyCode.DownArrow;
  static readonly KeyCode S = KeyCode.S;

  static readonly int mouse0 = 0;

  bool m_decelerate;
  bool m_accelerate;

  // Update is called once per frame
  void Update() {
//    if (Input.GetKeyDown(right) || Input.GetKeyUp(D)) {
//      Player.S.PM.SwitchLanes(Utils.Movement.Right);
//    }
//
//    if (Input.GetKeyDown(left) || Input.GetKeyUp(A)) {
//      Player.S.PM.SwitchLanes(Utils.Movement.Left);
//    }

    if (Input.GetKeyDown(up) || Input.GetKeyDown(W)) {
      m_decelerate = false;
      m_accelerate = true;
    }

    if (Input.GetKeyDown(down) || Input.GetKeyDown(S)) {
      m_accelerate = false;
      m_decelerate = true;
    }

    if (Input.GetKeyUp(up) || Input.GetKeyUp(W)) {
      m_accelerate = false;
    }

    if (Input.GetKeyUp(down) || Input.GetKeyUp(S)) {
      m_decelerate = false;
    }

    if (Input.GetMouseButton (0)) {
      Player.S.PM.MouseFollow (Input.mousePosition, transform.position);
      Player.S.PA.RotateVehicle ();
    }
	}

  void FixedUpdate() {
    if (m_decelerate) {
      Player.S.PM.adjustSpeed(-1);
    }

    if (m_accelerate) {
      Player.S.PM.adjustSpeed(1);
    }
  }
}
