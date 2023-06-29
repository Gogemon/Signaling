using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _shiftedSpeed;

    private SpriteRenderer _playerBody;
    private Animator _animator;

    private void Start()
    {
        _playerBody = GetComponent<SpriteRenderer>();
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            _playerBody.flipX = false;

            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.Translate(_shiftedSpeed * Time.deltaTime, 0, 0);
                _animator.SetInteger("Speed", 2);
            }
            else
            {
                transform.Translate(_speed * Time.deltaTime, 0, 0);
                _animator.SetInteger("Speed", 1);
                
            }
        }
        else if (Input.GetKey(KeyCode.A))
        {
            _playerBody.flipX = true;

            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.Translate(_shiftedSpeed * Time.deltaTime * -1, 0, 0);
                _animator.SetInteger("Speed", 2);
            }
            else
            {
                transform.Translate(_speed * Time.deltaTime * -1, 0, 0);
                _animator.SetInteger("Speed", 1);
            }
        }
        else
        {
            _animator.SetInteger("Speed", 0);
        }
    }
}
