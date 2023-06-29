using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Signaling : MonoBehaviour
{
    [SerializeField] private float _maxDelta;
    private float _maxVolumeValue = 1;
    private AudioSource _audioSource;
    private bool inCollision;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (inCollision)
        {
            _audioSource.volume = Mathf.MoveTowards(_audioSource.volume, _maxVolumeValue, _maxDelta * Time.deltaTime);
        }
        else
        {
            _audioSource.volume = Mathf.MoveTowards(_audioSource.volume, 0, _maxDelta * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        inCollision = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        inCollision = false;
    }
}
