using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

  public float speed;
  public float jumpForce;
  public bool grounded;

  int m_groundLayerMask;

	// Use this for initialization
	void Start () {
    grounded = true;
    m_groundLayerMask = LayerMask.GetMask(Utils.LAYER_GROUND);
	}
	
	// Update is called once per frame
	void Update () {
	}

  public void SwitchLanes (Utils.Movement direction) {
    Vector3 pos = transform.position;
    float newX = pos.x + Utils.DIRECTION_OFFSETS[(int) direction]; 

    //If moving would exceed bounds
    if (newX > Utils.MAX_X_POSITION || newX < Utils.MIN_X_POSITION) return;

    pos.x = newX;
    transform.position = pos;
  }

  bool Grounded () {
    return Physics.Raycast(transform.position, Vector3.down, 2, m_groundLayerMask);
  }
  
  public float targetX { get; set; } 
}
