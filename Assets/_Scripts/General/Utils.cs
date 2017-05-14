using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utils {

  public enum Movement { Left, Right, Straight };

  // Environment variables
  public static readonly float COMPONENT_LENGTH = 150f;
  public static readonly int NUM_SPEEDOMETER_BARS = 20;

  // Tags and layers
  public static readonly string PLAYER_TAG = "Player";
  public static readonly string LAYER_GROUND = "Ground";

  // Player position variables
  public static readonly float [] DIRECTION_OFFSETS = new float[2]{ -6, 6 };
  public static readonly float PLAYER_MAX_X_POSITION = 9f;
  public static readonly float PLAYER_MIN_X_POSITION = -9.125f;
  public static readonly float RESET_TRANSFORM_POS_Y = 1000f;

  // Player speed variables;
  public static readonly float PLAYER_MIN_SPEED = 10f;
  public static readonly float PLAYER_MAX_SPEED = 40f;
  public static readonly float PLAYER_START_SPEED = 25f;
}
