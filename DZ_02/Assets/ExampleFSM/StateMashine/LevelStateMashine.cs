using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStateMashine
{
    private Dictionary<Type, ILevelState> _states;
    private ILevelState _currentState;

    public LevelStateMashine()
    {
        _states = new Dictionary<Type, ILevelState>()
        {
            [typeof(InitializeStateMashine)] = new InitializeStateMashine(this),
            [typeof(LoadingLevelState)] = new LoadingLevelState(this)
        };
    }

    public void EnterIn<T>() where T: ILevelState
    {
        if(_states.TryGetValue(typeof(T), out ILevelState state))
        {
            _currentState?.Exit();
            _currentState = state;
            _currentState.Enter();
        }
    }
}
