using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doorway : MonoBehaviour
{
    [HideInInspector] public GameObject Entrance;
    [HideInInspector] public GameObject Exit;

    private void Awake()
    {
        Entrance = gameObject.transform.Find("Entrance").gameObject;
        Exit = gameObject.transform.Find("Exit").gameObject;
    }

    public void CooldownAllDors()
    {
        Transition exitTransition = Exit.GetComponent<Transition>();
        Transition entranceTransition = Entrance.GetComponent<Transition>();

        exitTransition.SetCooldown();
        entranceTransition.SetCooldown();
    }
}
