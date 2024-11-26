using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackState : EnemyBaseState  // inherit from base state
{

    private EnemyAIState enemyAI;

    public AttackState(EnemyAIState enemyAI)
    {
        this.enemyAI = enemyAI;
    }

    public override Type StateEnter()
    {
        return null;
    }

    public override Type StateExit()
    {
        return null;
    }

    public override Type StateUpdate()  // state to have enemy attack player
    {
        if (GameControllerScript.b_playerDead == true)  // checks if player has been caut
        {
            return typeof(WanderState);  // returns to wander state
        }
        else
        {
            enemyAI.Attack();  // resumes state
            return null;
        }
    }
}
