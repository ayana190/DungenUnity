using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour
{

    //アニメーションに関連あるプレイヤーの状態
    private enum PlayerMode
    { 
        Idle = 0,
        RightWalk = 1,
        FrontWalk = 2,
        LeftWalk = 3,
        BackWalk = 4,
    }

    //プレイヤーの状態

    private PlayerMode playerMode = PlayerMode.Idle;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
