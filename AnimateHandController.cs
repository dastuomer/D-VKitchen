using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Animator))] //attaches the animator to the gameobject
public class AnimateHandController : MonoBehaviour
{
    public InputActionReference gripInputActionReference;
    public InputActionReference triggerInputActionReference;

    private Animator _handAnimator;
    private float _gripValue;
    private float _triggerValue;

    private void start()
    {
        _handAnimator = GetComponent<Animator>(); // gets the hand animator
    }

    private void Update() //updates every frame
    {
        AnimateGrip();
        AnimateTrigger();
    }

    private void AnimateGrip() // assign the grip value
    {
        _gripValue = gripInputActionReference.action.ReadValue<float>();
        _handAnimator.SetFloat("Grip", _gripValue);
    }

    private void AnimateTrigger()// assign the trigger value
    {
        _triggerValue = triggerInputActionReference.action.ReadValue<float>();
        _handAnimator.SetFloat("Trigger", _triggerValue);
    }

}
