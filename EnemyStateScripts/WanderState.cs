using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderState : EnemyBaseState


{

    private EnemyAIState enemyAI;
    // Start is called before the first frame update

    public WanderState(EnemyAIState enemyAI)
    {
        this.enemyAI = enemyAI;
    }


    public override Type StateEnter()
    {
        enemyAI.agent.isStopped = false;
        return null;
    }

    public override Type StateExit()
    {
        return null;
    }


    public override Type StateUpdate()
    {
        if (GameControllerScript.gameOver == true)
        {
            return typeof(AttackState);  // goes to attack state
        }
        else if (GameControllerScript.b_enemyExamening == true)
        {
            return typeof(ExamenState);  // goes to examen state
        }
        else
        {
            enemyAI.Wander();
            return null;
        }
    }
}
