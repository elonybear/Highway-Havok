using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highway : MonoBehaviour {

  public static Highway S;

  public GameObject highwayComponent;

  List<GameObject> m_instantiatedComponents;

	// Use this for initialization
	void Awake () {

    S = this;

	  m_instantiatedComponents = new List<GameObject>();	

    GameObject component = GameObject.Instantiate<GameObject>(highwayComponent);
    component.transform.position = Vector3.zero;
    component.transform.parent = transform;

    m_instantiatedComponents.Add(component);
	}

  public void PlayerTriggered (Vector3 pos) {
    GameObject component = GameObject.Instantiate<GameObject>(highwayComponent);
    pos.y += Utils.COMPONENT_LENGTH;
    component.transform.position = pos;
    component.transform.parent = transform;

    m_instantiatedComponents.Add(component);

    if (m_instantiatedComponents.ToArray().Length > 2) {
      Destroy(m_instantiatedComponents[0]);
      m_instantiatedComponents.RemoveAt(0);
    } 
  } 

  public void ResetHighway () {
    foreach(GameObject comp in m_instantiatedComponents) {
      Vector3 pos = comp.transform.position;
      pos.y -= Utils.RESET_TRANSFORM_POS_Y;
      comp.transform.position = pos;
    }
  }
}
