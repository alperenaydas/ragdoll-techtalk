using System.Collections.Generic;
using UnityEngine;

public class RagdollController : MonoBehaviour
{
    private bool _lastState = false;
    public Animator Animator;
    public List<Rigidbody> RigidbodiesOfRagdoll;
    public List<Collider> CollidersOfRagdoll;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            _lastState = !_lastState;
            ToggleRagdoll(_lastState);
        }
    }

    public void ToggleRagdoll(bool state)
    {
        Animator.enabled = !state;
        foreach (var rigidbody in RigidbodiesOfRagdoll)
        {
            rigidbody.isKinematic = !state;
        }

        foreach (var collider in CollidersOfRagdoll)
        {
            collider.enabled = state;
        }
    }
}
