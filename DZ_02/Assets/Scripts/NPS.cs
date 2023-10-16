using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class NPS : MonoBehaviour
{
    private NpsStateMachine _stateMachine;
    private CharacterController _characterController;

    private void Awake()
    {
        _characterController = GetComponent<CharacterController>();
        _stateMachine = new NpsStateMachine();
    }

    private void Update()
    {
        _stateMachine.Update();
    }

}
