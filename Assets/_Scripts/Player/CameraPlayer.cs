using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraPlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

  void OnCollisionEnter(Collision other) {
    if (other.gameObject.layer == LayerMask.NameToLayer(Utils.LAYER_TRAFFIC))
    {
      SceneManager.LoadScene("Gameplay");
    }
  }
}
