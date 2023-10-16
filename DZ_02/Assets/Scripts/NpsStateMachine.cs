using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class NpsStateMachine: IStateSwitcher
{
    private List<IState> _state;
    private IState _currentState;

    public NpsStateMachine()
    {
        _state = new List<IState>();

        _currentState = _state[0];
        _currentState.Enter();
    }

    public void SwitchState<T>() where T : IState
    {
        IState state = _state.FirstOrDefault(state => state is T);

        _currentState.Exit();
        _currentState = state;
        _currentState.Enter();
    }

    public void Update() 
    {
        _currentState.Update();
    }
}
