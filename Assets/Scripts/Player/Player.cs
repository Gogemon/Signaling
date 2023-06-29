using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private BackgroundCheinger _backgroundCheinger;

    private void Start()
    {
        _backgroundCheinger = gameObject.transform.Find("Background").gameObject.GetComponent<BackgroundCheinger>();
    }

    public void ChengeBackground()
    {
        _backgroundCheinger.ChangeDarkenBackground();
    }
}
