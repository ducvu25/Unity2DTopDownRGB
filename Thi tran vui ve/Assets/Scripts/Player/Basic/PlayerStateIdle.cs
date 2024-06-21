using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateIdle : PlayerStateBasic
{
    public PlayerStateIdle(string name, float time, PlayerStateMachine stateMachine, Player player) : base(name, time, stateMachine, player)
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
        if(move != Vector2.zero)
        {
            this.stateMachine.SetState(this.player.state_run);
        }
    }
    override public void Exit()
    {
        base.Exit();
    }
}
