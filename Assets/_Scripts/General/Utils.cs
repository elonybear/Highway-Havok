using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utils {

  // Environment variables
  public static readonly float COMPONENT_LENGTH = 150;

  
  // Tags and layers
  public static readonly string PLAYER_TAG = "Player";

  public static readonly string LAYER_GROUND = "Ground";


  public enum Movement { Left, Right, Straight };

  public static readonly float [] DIRECTION_OFFSETS = new float[2]{ -6, 6 };

  public static readonly float MAX_X_POSITION = 8.875f;
  public static readonly float MIN_X_POSITION = -9.125f;
}
