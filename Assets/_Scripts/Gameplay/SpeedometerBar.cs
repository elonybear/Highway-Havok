using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedometerBar : MonoBehaviour {

  float m_threshold;
  MeshRenderer m_mesh;

	// Use this for initialization
	void Start () {
    m_mesh = GetComponent<MeshRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Player.S.PM.speed < m_threshold && m_mesh.enabled) {
      m_mesh.enabled = false;
    }

    if (Player.S.PM.speed >= m_threshold && !m_mesh.enabled) {
      m_mesh.enabled = true;
    }
	}

  public void setThreshold (float threshold_in) {
    m_threshold = threshold_in;
  }
}
