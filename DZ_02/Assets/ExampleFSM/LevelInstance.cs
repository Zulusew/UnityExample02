using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelInstance : MonoBehaviour
{
    private LevelStateMashine _levelStateMeshine;

    private void Awake()
    {
        _levelStateMeshine = new LevelStateMashine();

        _levelStateMeshine.EnterIn<LoadingLevelState>();
    }


}
