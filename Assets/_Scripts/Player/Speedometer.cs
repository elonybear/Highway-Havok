using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speedometer : MonoBehaviour {

	// Use this for initialization
	void Start () {
    for (int i = 0; i < transform.childCount; i++) {
      Transform child = transform.GetChild(i);
      float threshold = Utils.PLAYER_MIN_SPEED + i * (Utils.PLAYER_MAX_SPEED - Utils.PLAYER_MIN_SPEED) / transform.childCount;
      child.GetComponent<SpeedometerBar>().setThreshold(threshold);
    }
	}
}
