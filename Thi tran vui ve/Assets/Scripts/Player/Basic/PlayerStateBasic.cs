using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerStateBasic : PlayerState
{
    public PlayerStateBasic(string name, float time, PlayerStateMachine stateMachine, Player player) : base(name, time, stateMachine, player)
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
