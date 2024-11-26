using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExamenState : EnemyBaseState
{
    // Start is called before the first frame update

    private EnemyAIState enemyAI;
    private float time;

    public ExamenState(EnemyAIState enemyAI)
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

    public override Type StateUpdate()
    {
        time += Time.deltaTime;
        if (time > 5)  // returns to wander state after 5 seconds
        {
            time = 0;
            GameControllerScript.b_enemyExamening = false;
            return typeof(WanderState);
        }
        else if (GameControllerScript.gameOver == true)
        {
            return typeof(AttackState);  // goes to attack state
        }
        else
        {
            enemyAI.Examen();
            return null;
        }
    }
}
