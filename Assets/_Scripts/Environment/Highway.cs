using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highway : MonoBehaviour {

  public static Highway S;

  public GameObject highwayComponent;

  List<GameObject> instantiatedComponents;

	// Use this for initialization
	void Awake () {

    S = this;

	  instantiatedComponents = new List<GameObject>();	

    GameObject component = GameObject.Instantiate<GameObject>(highwayComponent);
    component.transform.position = Vector3.zero;
    component.transform.parent = transform;

    instantiatedComponents.Add(component);
	}

  public void PlayerTriggered (Vector3 pos) {
    GameObject component = GameObject.Instantiate<GameObject>(highwayComponent);
    pos.z += Utils.COMPONENT_LENGTH;
    component.transform.position = pos;
    component.transform.parent = transform;

    instantiatedComponents.Add(component);

    if (instantiatedComponents.ToArray().Length > 2) {
      Destroy(instantiatedComponents[0]);
      instantiatedComponents.RemoveAt(0);
    } 
  } 
}
