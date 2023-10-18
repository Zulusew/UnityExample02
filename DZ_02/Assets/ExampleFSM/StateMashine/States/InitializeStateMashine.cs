using System.Collections;
using UnityEngine;

public class InitializeStateMashine : ILevelState
{
    private LevelStateMashine _levelStateMashine;

    public InitializeStateMashine(LevelStateMashine levelStateMashine)
    {
        _levelStateMashine = levelStateMashine;
    }

    public void Enter()
    {
        Debug.Log("Enter Initialize LevelState");
    }

    public void Exit()
    {
        Debug.Log("Exit Initialize LevelState");
    }
}