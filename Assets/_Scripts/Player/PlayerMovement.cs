using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

  Rigidbody m_parentRigidbody;

  int m_groundLayerMask;
  float m_speed;
  // Use this for initialization
  void Start()
  {
    targetX = transform.position.x;
    m_speed = Utils.PLAYER_START_SPEED;
    m_parentRigidbody = transform.parent.GetComponent<Rigidbody>();

    m_parentRigidbody.velocity = Vector3.up * m_speed;
  }

  // Update is called once per frame
  void Update()
  {

  }

  public void SwitchLanes(Utils.Movement direction)
  {
    float newX = targetX + Utils.DIRECTION_OFFSETS[(int)direction];

    //If moving would exceed bounds
    if (newX > Utils.PLAYER_MAX_X_POSITION || newX < Utils.PLAYER_MIN_X_POSITION) return;

    targetX = newX;
    Player.S.PA.InitiateSwitch(targetX, direction);
    //transform.position = pos;
  }

  public void adjustSpeed(float adjustment) {

    if (m_speed + adjustment < Utils.PLAYER_MIN_SPEED || m_speed + adjustment > Utils.PLAYER_MAX_SPEED) return;

    m_speed += adjustment;
    m_parentRigidbody.velocity = Vector3.up * m_speed;
  }

  public float targetX { get; set; }

  public float speed {
    get {
      return m_speed;
    }
  }
}
