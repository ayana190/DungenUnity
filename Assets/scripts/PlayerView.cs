using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour
{

    //�A�j���[�V�����Ɋ֘A����v���C���[�̏��
    private enum PlayerMode
    { 
        Idle = 0,
        RightWalk = 1,
        FrontWalk = 2,
        LeftWalk = 3,
        BackWalk = 4,
    }

    //�v���C���[�̏��

    private PlayerMode playerMode = PlayerMode.Idle;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
