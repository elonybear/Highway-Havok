using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighwayComponent : MonoBehaviour {
  void OnTriggerEnter (Collider other) {
    if (other.gameObject.tag == Utils.PLAYER_TAG)
      Highway.S.PlayerTriggered(transform.position);
  }
}
