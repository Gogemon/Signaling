using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transition : MonoBehaviour
{
    [SerializeField] private bool _isDoorInHouse;
    private GameObject _secondDoor;
    private Doorway _doorway;
    private float _transitionTime;
    private float _transitionTimeCooldown = 1;

    private void Start()
    {
        var parent = gameObject.transform.parent.gameObject;
        _doorway = parent.GetComponent<Doorway>();

        if (_isDoorInHouse)
        {
            _secondDoor = _doorway.Entrance;
        }
        else
        {
            _secondDoor = _doorway.Exit;
        }
    }

    private void Update()
    {
        if (_transitionTime > 0)
            _transitionTime -= Time.deltaTime;
    }

    public void SetCooldown()
    {
        _transitionTime = _transitionTimeCooldown;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Player>(out Player player))
        {
            if (Input.GetKey(KeyCode.E) && _transitionTime <= 0)
            {
                _doorway.CooldownAllDors();
                player.ChengeBackground();
                player.transform.position = _secondDoor.transform.position;
            }
        }
    }
}
