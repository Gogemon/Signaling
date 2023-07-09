using UnityEngine;

public class PlayerAnimationSetter : MonoBehaviour
{
    private const string SpeedAnimator = "Speed";

    private Animator _animator;

    public void MuveAnimations(int animationNumber)
    {
        _animator.SetInteger(SpeedAnimator, animationNumber);
    }

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }
}
