using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetAniState : MonoBehaviour
{
    Player player;
    private void Awake()
    {
        player = GetComponentInParent<Player>();
    }
    // Start is called before the first frame update
    public void DefaultAni()
    {
        this.player.stateMachine.SetState(this.player.state_idle);
    }
}
