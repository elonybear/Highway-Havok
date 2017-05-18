using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour {

  bool m_switching;
  float m_target;
  Utils.Movement m_direction;

	// Use this for initialization
	void Start () {
    m_switching = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (m_switching) {

      Vector3 pos = transform.position;

      switch (m_direction) {
        case Utils.Movement.Left:
          //check if position X is less than target
          if (pos.x < m_target) {
            pos.x = m_target;
            m_switching = false;
          } else {
            pos.x -= Utils.PLAYER_ANIM_SPEED * Time.deltaTime / 2;
          }
          break;
        case Utils.Movement.Right:
          //check if position X is less than target
          if (pos.x > m_target) {
            pos.x = m_target;
            m_switching = false;
          } else {
            pos.x += Utils.PLAYER_ANIM_SPEED * Time.deltaTime / 2;
          }
          break;
      }

      transform.position = pos;
    }
	}

  public void InitiateSwitch (float target_in, Utils.Movement direction_in) {
    m_switching = true;
    m_target = target_in;
    m_direction = direction_in;
  }

  public void RotateVehicle(){
    Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
    Vector3 dir = Input.mousePosition - pos;

    //Angle between mouse and current rot
    float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
    Quaternion target = Quaternion.AngleAxis(angle, transform.forward);

    print (angle); 

    transform.rotation =  Quaternion.Slerp (transform.rotation, target, 0.6f * Time.deltaTime);
  }
}
