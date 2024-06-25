using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatePlayerWaterTheTree : PlayerStateProduction
{
    public PlayerStatePlayerWaterTheTree(string name, float time, PlayerStateMachine stateMachine, Player player) : base(name, time, stateMachine, player)
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
