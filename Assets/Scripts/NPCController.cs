using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;

public class NPCController : MonoBehaviour
{
    [SerializeField] private GameObject _target;
    [SerializeField] private GameObject _target2;
    private bool isTarget1 = true;
    private GameObject _actualTarget;
    private NavMeshAgent _agent;
    private Animator _animator;

    private void Start()
    {
        _actualTarget = _target;
        _agent = GetComponent<NavMeshAgent>();
        _animator = GetComponent<Animator>();
        Debug.Log(_animator);
    }
    private void Update()
    {
        _animator.SetFloat("Speed", _agent.velocity.magnitude);
        if (Keyboard.current.eKey.wasPressedThisFrame)
        {
            _agent.SetDestination(_actualTarget.transform.position);
            if (isTarget1 == true)
            {
                _actualTarget = _target2;
                isTarget1 = false;
            }
            else
            {
                _actualTarget = _target;
                isTarget1 = true;
            }
        }
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            _animator.SetBool("isJumping", true);
        }
    }
}
