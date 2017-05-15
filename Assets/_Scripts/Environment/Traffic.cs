using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traffic : MonoBehaviour {

  //Initialize in Inspector
  public GameObject [] vehicles;

  float m_timeLastSpawn;
  int m_lastLane;
  int m_lastVehicle;

  // Use this for initialization
  void Start () {
    m_timeLastSpawn = -1;
    m_lastLane = -1;
    m_lastVehicle = -1;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time - m_timeLastSpawn > Utils.CURRENT_SPAWN_TIME) {
      //Spawn random vehicle in random lane
      SpawnVehicle();
    }
	}

  void SpawnVehicle () {
    //Find random lane to place vehicle obstacle - AVOID TWO IN A ROW
    int lane;

    do
    {
      lane = Random.Range(0, Utils.LANE_POSITIONS.Length);
    } while (lane == m_lastLane);


    //Find random vehicle - AVOID TWO IN A ROW
    int vehicle = 0;

    do
    {
      vehicle = Random.Range(0, vehicles.Length);
    } while (vehicle == m_lastVehicle && vehicles.Length > 1);

    GameObject newVehicle = Instantiate<GameObject>(vehicles[vehicle]);
    newVehicle.transform.parent = transform;

    //Place random vehicle in random lane - x position
    Vector3 pos = newVehicle.transform.position;
    pos.x = Utils.LANE_POSITIONS[lane]; //appropriate lane
    pos.y = Player.S.transform.position.y + Utils.NPC_SPAWN_DIFFERENCE; //Out of player sight
    newVehicle.transform.position = pos;

    m_timeLastSpawn = Time.time;
    m_lastLane = lane;
    m_lastVehicle = vehicle;
  }
}
