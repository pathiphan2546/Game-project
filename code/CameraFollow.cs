using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Transform cameraTarget;
    public Vector3 offset;
    [Range(1,10)]
    public float smoothFactor;

    private void FixedUpdate()
    {
        Follow();
    }

    void Follow()
    {
        Vector3 targetPosition = target.position + offset;
        Vector3 smoothCam = Vector3.Lerp(transform.position, targetPosition, smoothFactor * Time.deltaTime);
        cameraTarget.position = smoothCam;
    }
}