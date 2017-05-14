using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour {

  public float animSpeed;

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
            pos.x -= animSpeed * Time.deltaTime / 2;
          }
          break;
        case Utils.Movement.Right:
          //check if position X is less than target
          if (pos.x > m_target) {
            pos.x = m_target;
            m_switching = false;
          } else {
            pos.x += animSpeed * Time.deltaTime / 2;
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
}
