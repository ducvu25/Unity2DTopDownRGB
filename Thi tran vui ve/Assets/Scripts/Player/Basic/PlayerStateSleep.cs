using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateSleep : PlayerStateBasic
{
    public PlayerStateSleep(string name, float time, PlayerStateMachine stateMachine, Player player) : base(name, time, stateMachine, player)
    {

    }
    override public void Enter()
    {
        base.Enter();
    }
    override public void Update()
    {
        base.Update();
    }
    override public void FixedUpdate()
    {
        base.FixedUpdate();

    }
    override public void Exit()
    {
        base.Exit();
    }
}