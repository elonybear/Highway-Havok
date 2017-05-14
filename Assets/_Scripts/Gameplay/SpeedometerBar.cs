using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedometerBar : MonoBehaviour {

  public float threshold;

  MeshRenderer mesh;

	// Use this for initialization
	void Start () {
    mesh = GetComponent<MeshRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Player.S.PM.speed <= threshold && mesh.enabled) {
      mesh.enabled = false;
    }

    if (Player.S.PM.speed > threshold && !mesh.enabled) {
      mesh.enabled = true;
    }
	}
}
