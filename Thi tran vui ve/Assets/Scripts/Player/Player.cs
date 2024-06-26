using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Player : MonoBehaviour
{
    public float moveSpeed = 1f;
    public HuongNhanVat huongNhin;
    public StateProduction stateProduction;
    public PlayerStateMachine stateMachine {get; private set;}
    public PlayerStateIdle state_idle { get; private set;}
    public PlayerStateRun state_run { get; private set;}
    public PlayerStateHeo state_heo { get; private set;}
    public PlayerStateCutDownTheTree state_cut_down_the_tree { get; private set;}
    public PlayerStatePlayerWaterTheTree state_water_the_tree{ get; private set;}
    //public PlayerStatePawn state_pawn { get; private set;}
    //public PlayerStateSleep state_sleep { get; private set;}


    public bool isPawn { get; private set; }

    [HideInInspector]
    public Rigidbody2D rb { get; private set; }
    public Animator ani { get; private set; }
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        ani = GetComponentInChildren<Animator>();
    }
    // Start is called before the first frame update
    void Start()
    {
        isPawn = false;
        stateMachine = new PlayerStateMachine();
        state_idle = new PlayerStateIdle(ManagerSetting.NAME_STATE_PLAYER_IDLE, 0, stateMachine, this);
        state_run = new PlayerStateRun(ManagerSetting.NAME_STATE_PLAYER_RUN, 0, stateMachine, this);
        state_heo = new PlayerStateHeo(ManagerSetting.NAME_STATE_PLAYER_HEO, 0, stateMachine, this);
        state_cut_down_the_tree = new PlayerStateCutDownTheTree(ManagerSetting.NAME_STATE_PLAYER_CUT_DOWN_THE_TREE, 0, stateMachine, this);
        state_water_the_tree = new PlayerStatePlayerWaterTheTree(ManagerSetting.NAME_STATE_PLAYER_WATE_THE_TREE, 0, stateMachine, this);
        //state_pawn = new PlayerStatePawn(ManagerSetting.NAME_STATE_PLAYER_PAWN, 0, stateMachine, this);
        //state_sleep = new PlayerStateSleep(ManagerSetting.NAME_STATE_PLAYER_SLEEP, 0, stateMachine, this);

        stateMachine.InitState(state_idle);
    }
    
    // Update is called once per frame
    void Update()
    {
       stateMachine.state.Update();
    }
    private void FixedUpdate()
    {
        stateMachine.state.FixedUpdate();
    }
    
}

