using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : MonoBehaviour
{
    protected string nameState;
    protected float timeState;
    protected PlayerStateMachine stateMachine;
    protected Rigidbody2D rb;
    protected Animator ani;
    protected Player player;
    protected Vector2 move;
    public PlayerState(string name, float time, PlayerStateMachine stateMachine, Player player)
    {
        this.nameState = name;
        this.timeState = time;
        this.stateMachine = stateMachine;
        this.rb = player.rb;
        this.ani = player.ani;
        this.player = player;
    }
    virtual public void Enter()
    {
        this.ani.SetBool(this.nameState, true);
    }
    virtual public void Update()
    {
        if(this.timeState > 0)
            this.timeState-= Time.deltaTime;
        move = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        if (move.x > 0)
        {
            this.player.huongNhin = HuongNhanVat.right;
            player.transform.localScale = new Vector3(-Mathf.Abs(player.transform.localScale.x), player.transform.localScale.y, player.transform.localScale.z);
        }
        else if (move.x < 0)
        {
            this.player.huongNhin = HuongNhanVat.left;
            player.transform.localScale = new Vector3(Mathf.Abs(player.transform.localScale.x), player.transform.localScale.y, player.transform.localScale.z);
        }
        if (move.y > 0)
            this.player.huongNhin = HuongNhanVat.up;
        else if (move.y < 0)
            this.player.huongNhin = HuongNhanVat.down;

        if (Input.GetKeyDown(KeyCode.Q))
        {
            this.SetState(this.player.stateProduction);
        }  
    }
    virtual public void FixedUpdate()
    {
        this.ani.SetFloat(ManagerSetting.FACE_PLAYER, (int)this.player.huongNhin);
    }
    virtual public void Exit() {
        this.ani.SetBool(this.nameState, false);
    }
    void SetState(StateProduction state)
    {
        switch (state)
        {
            case StateProduction.heo:
                {
                    this.stateMachine.SetState(this.player.state_heo);
                    break;
                }
            case StateProduction.cut_down_the_tree:
                {
                    this.stateMachine.SetState(this.player.state_cut_down_the_tree);
                    break;
                }
            case StateProduction.water_the_tree:
                {
                    this.stateMachine.SetState(this.player.state_water_the_tree);
                    break;
                }
        }
    }
}
