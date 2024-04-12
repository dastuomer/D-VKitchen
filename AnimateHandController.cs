using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Animator))] // the animator component to be attached to the GameObject
public class AnimateHandController : MonoBehaviour
{
    public InputActionReference gripInputActionReference; // reference to grip input action
    public InputActionReference triggerInputActionReference; // reference to trigger input action

    private Animator _handAnimator; // reference to the animator component
    private float _gripValue; // storing the value of grip input
    private float _triggerValue; // storing the value of trigger input

    private void Start() // called when the GameObject is first enabled
    {
        _handAnimator = GetComponent<Animator>(); // getting the animator component attached to the GameObject
    }

    private void Update() // called for every frame
    {
        AnimateGrip(); // animate grip based on input
        AnimateTrigger(); // animate trigger based on input
    }

    private void AnimateGrip() // animate grip based on input value
    {
        _gripValue = gripInputActionReference.action.ReadValue<float>(); // reading the value of the grip input
        _handAnimator.SetFloat("Grip", _gripValue); // setting the "Grip" parameter in the animator to the grip value
    }

    private void AnimateTrigger() // animate trigger based on input value
    {
        _triggerValue = triggerInputActionReference.action.ReadValue<float>(); // reading the value of the trigger input
        _handAnimator.SetFloat("Trigger", _triggerValue); // setting the "Trigger" parameter in the Animator to the trigger value
    }
}
