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

    Utils.CURRENT_SPAWN_TIME = Utils.MAX_SPAWN_TIME - (Utils.MAX_SPAWN_TIME - Utils.MIN_SPAWN_TIME) * (m_speed - Utils.PLAYER_MIN_SPEED) / (Utils.PLAYER_MAX_SPEED - Utils.PLAYER_MIN_SPEED) * .5f; 

    m_parentRigidbody.velocity = Vector3.up * m_speed;

    Utils.CURRENT_POINT_MULTIPLIER = Utils.MAX_POINT_MULTIPLIER - (Utils.MAX_POINT_MULTIPLIER - Utils.MIN_POINT_MULTIPLIER) * (m_speed - Utils.PLAYER_MAX_SPEED) / (Utils.PLAYER_MAX_SPEED - Utils.PLAYER_MIN_SPEED) * 2;
  }

  public float targetX { get; set; }

  public float speed {
    get {
      return m_speed;
    }
  }
}
