using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum HuongNhanVat
{
    up, 
    left, 
    down, 
    right
}
public enum StateProduction
{
    state_default,
    heo,
    cut_down_the_tree,
    water_the_tree
}
public static class ManagerSetting 
{
    public static string FACE_PLAYER = "Huong";
    public static string NAME_STATE_PLAYER_IDLE = "Idle";
    public static string NAME_STATE_PLAYER_RUN = "Run";
    public static string NAME_STATE_PLAYER_PAWN = "Pawn";
    public static string NAME_STATE_PLAYER_SLEEP = "Sleep";
    public static string NAME_STATE_PLAYER_HEO = "Heo";
    public static string NAME_STATE_PLAYER_CUT_DOWN_THE_TREE = "CutDownTheTree";
    public static string NAME_STATE_PLAYER_WATE_THE_TREE = "WaterTheTree";
}
