using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandAnimatorController : MonoBehaviour
{
    [SerializeField] private InputActionProperty triggerAction; // reference to the trigger input action
    [SerializeField] private InputActionProperty gripAction; // reference to the grip input action

    private Animator anim; // referencing the Animator component

    private void Start()
    {
        anim = GetComponent<Animator>(); // getting the Animator component attached to the GameObject
    }

    private void Update()
    {
        // reading the current value of the trigger input 
        float triggerValue = triggerAction.action.ReadValue<float>();
        // reading the current value of the grip input 
        float gripValue = gripAction.action.ReadValue<float>();

        // setting the "Trigger" parameter to the trigger value
        anim.SetFloat("Trigger", triggerValue);
        // setting the "Grip" parameter to the grip value
        anim.SetFloat("Grip", gripValue);
    }
}
