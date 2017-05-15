using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

  public int score;

  public Text scoreText;

	// Use this for initialization
	void Start () {
	  score = 0;	
    scoreText.text = score.ToString();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	  score += (int) Mathf.Floor(Utils.BASE_POINT_ADDITION * Utils.CURRENT_POINT_MULTIPLIER);	
    scoreText.text = score.ToString();
	}
}
