using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EnemyStateMachine : MonoBehaviour
{

    private Dictionary<Type, EnemyBaseState> states;
    public EnemyBaseState currentState;
    public EnemyBaseState CurrentState  //get current state
    {
        get
        {
            return currentState;
        }
        private set
        {
            currentState = value;
        }
    }

    public void SetStates(Dictionary<Type, EnemyBaseState> states)  // set state
    {
        this.states = states;
    }



    // Update is called once per frame
    void Update()
    {
        if (CurrentState == null)
        {
            CurrentState = states.Values.First();  // sets current state to first state
        }
        else
        {
            var nextState = CurrentState.StateUpdate();
            if (nextState != null && nextState != CurrentState.GetType())  // switch state
            {
                SwitchToState(nextState);  
            }
        }
    }

    void SwitchToState(Type nextState)  // switch state protocol
    {
        CurrentState.StateExit();
        CurrentState = states[nextState];
        CurrentState.StateEnter();
    }
}
