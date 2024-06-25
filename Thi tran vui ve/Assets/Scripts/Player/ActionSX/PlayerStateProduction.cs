using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateProduction : PlayerState
{
    public PlayerStateProduction(string name, float time, PlayerStateMachine stateMachine, Player player) : base(name, time, stateMachine, player)
    {

    }
    override public void Enter()
    {
        base.Enter();
        rb.velocity = Vector3.zero;
    }
    override public void Update()
    {
        base.Update();
    }
    override public void FixedUpdate()
    {
        base.FixedUpdate();
        if(this.timeState < 0)
        {
            this.stateMachine.SetState(this.player.state_idle); ;
        }
    }
    override public void Exit()
    {
        base.Exit();
    }
}
