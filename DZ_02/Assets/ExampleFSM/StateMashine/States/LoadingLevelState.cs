using System.Collections;
using UnityEngine;

public class LoadingLevelState : ILevelState
{
    private LevelStateMashine _levelStateMashine;

    public LoadingLevelState(LevelStateMashine levelStateMashine)
    {
        _levelStateMashine = levelStateMashine;
    }

    public void Enter()
    {
        Debug.Log("Enter loading LevelState");

        _levelStateMashine.EnterIn<InitializeStateMashine>();
    }

    public void Exit()
    {
        Debug.Log("Exit loading LevelState");
    }
}