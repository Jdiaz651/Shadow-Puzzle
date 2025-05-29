using UnityEngine;

public class QuaternionRotationMatcher : MonoBehaviour
{
    public Transform target;
    public Transform playerObject;
    [Range(0.9f, 1f)] public float dotThreshold = 0.999f;

    void Update()
    {
        if (AreRotationsClose(playerObject.rotation, target.rotation))
        {
            playerObject.rotation = target.rotation;
        }
    }

    bool AreRotationsClose(Quaternion a, Quaternion b)
    {
        float dot = Quaternion.Dot(a.normalized, b.normalized);
        return Mathf.Abs(dot) >= dotThreshold;
    }

    public bool IsPuzzleSolved()
    {
        return AreRotationsClose(playerObject.rotation, target.rotation);
    }
    
}
