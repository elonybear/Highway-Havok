using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlayer : MonoBehaviour {

  public float speed;

  Rigidbody m_rigid;

	// Use this for initialization
	void Start () {
    m_rigid = GetComponent<Rigidbody>();
    m_rigid.velocity = Vector3.up * speed;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
