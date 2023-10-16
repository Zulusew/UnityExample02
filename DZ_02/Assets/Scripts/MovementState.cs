using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementState : MonoBehaviour
{
    protected readonly IStateSwitcher StateSwitcher;
    private readonly NPS _nps;
    private float InputX;

    public MovementState(IStateSwitcher stateSwitcher, NPS nps)
    {
        StateSwitcher = stateSwitcher;
        _nps = nps;
    }
}
