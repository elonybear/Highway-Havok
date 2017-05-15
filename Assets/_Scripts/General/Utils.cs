using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utils {

  public enum Movement { Left, Right, Straight };

  // Environment variables
  public static readonly float COMPONENT_LENGTH = 150f;
  public static readonly int NUM_SPEEDOMETER_BARS = 20;
  public static readonly float SPAWN_TIME = .75f;

  // Tags and layers
  public static readonly string PLAYER_TAG = "Player";
  public static readonly string LAYER_GROUND = "Ground";
  public static readonly string LAYER_TRAFFIC = "Traffic";

  // Player position variables
  public static readonly float [] DIRECTION_OFFSETS = new float[2]{ -6, 6 };
  public static readonly float PLAYER_MAX_X_POSITION = 9.125f;
  public static readonly float PLAYER_MIN_X_POSITION = -9.125f;
  public static readonly float RESET_TRANSFORM_POS_Y = 1000f;

  // Global position variables
  public static readonly float LEFT_LANE = -8.875f;
  public static readonly float LEFT_MIDDLE_LANE = -2.875f;
  public static readonly float RIGHT_MIDDLE_LANE = 2.875f;
  public static readonly float RIGHT_LANE = 8.875f;
  public static readonly float [] LANE_POSITIONS = new float[4] { LEFT_LANE, LEFT_MIDDLE_LANE, RIGHT_MIDDLE_LANE, RIGHT_LANE };

  // NPC position variables
  public static readonly float NPC_SPAWN_DIFFERENCE = 50f;

  // Player speed variables;
  public static readonly float PLAYER_MIN_SPEED = 10f;
  public static readonly float PLAYER_MAX_SPEED = 40f;
  public static readonly float PLAYER_START_SPEED = 25f;
}
