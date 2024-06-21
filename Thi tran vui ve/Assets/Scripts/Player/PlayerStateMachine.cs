using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine 
{
    public PlayerState state { get; private set; }
    public PlayerStateMachine() { }
    public void InitState(PlayerState state)
    {
        this.state = state;
        this.state.Enter();
    }
    public void SetState(PlayerState state)
    {
        this.state.Exit();
        this.state = state;
        this.state.Enter();
    }
}
