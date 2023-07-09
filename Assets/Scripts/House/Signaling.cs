using System.Collections;
using UnityEngine;

public class Signaling : MonoBehaviour
{
    [SerializeField] private float _maxDelta;

    private Coroutine _changeVolumeCoroutine;
    private AudioSource _audioSource;

    public void StartCoroutine(bool isExit)
    {
        float volumeValue = isExit ? 0.0f : 1.0f;

        if (_changeVolumeCoroutine != null)
        {
            StopChangeVolumeCoroutine();
        }

        _changeVolumeCoroutine = StartCoroutine(ChangeVolume(volumeValue));
    }

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private IEnumerator ChangeVolume(float volumeValue)
    {
        bool isWorking = true;

        while (isWorking)
        {
            _audioSource.volume = Mathf.MoveTowards(_audioSource.volume, volumeValue, _maxDelta * Time.deltaTime);

            if (_audioSource.volume == volumeValue)
            {
                StopChangeVolumeCoroutine();
            }

            yield return null;
        }
    }
    
    private void StopChangeVolumeCoroutine()
    {
        StopCoroutine(_changeVolumeCoroutine);
    }
}
