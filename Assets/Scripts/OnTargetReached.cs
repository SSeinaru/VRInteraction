using UnityEngine;
using UnityEngine.Events;

public class OnTargetReached : MonoBehaviour
{
    [SerializeField] private float threshold;
    public Transform target;
    public UnityEvent OnReached;
    private bool wasReached = false;

    public void FixedUpdate()
    {
        float distance = Vector3.Distance(transform.position, target.position);

        if (distance < threshold && !wasReached)
        {
            OnReached.Invoke();
            wasReached = true;
        }
        else if (distance >= threshold)
        {
            wasReached = false; // Reset when moving away from the target
        } 
    }
}
