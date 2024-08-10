using Cinemachine;
using UnityEngine;

public class CameraHeadBob : MonoBehaviour
{
    public CinemachineVirtualCamera virtualCamera;
    public PlayerMovementAdvanced playerMovement;
    public Rigidbody playerRigidbody;  // Assuming the player has a Rigidbody component
    private CinemachineBasicMultiChannelPerlin noise;
    public float velocityThreshold = 1f;  // Minimum velocity to apply noise
    public float noiseIntensity = 1f;     // Intensity of the noise
    public float noiseFrequency = 1f;
    public float smoothTime = 0.2f;

    private Vector3 originalLocalPosition;
    private Vector3 velocity = Vector3.zero;
    void Start()
    {
        noise = virtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
        originalLocalPosition = virtualCamera.transform.localPosition;
    }

    void Update()
    {
        float playerSpeed = playerRigidbody.velocity.magnitude;

        if (playerSpeed > velocityThreshold && !playerMovement.IsCrouching && !playerMovement.IsFalling)
        {
            // Increase noise intensity based on player speed
            noise.m_AmplitudeGain = noiseIntensity * (playerSpeed - velocityThreshold);
            noise.m_FrequencyGain = noiseFrequency * (playerSpeed - velocityThreshold);
        }
        else
        {

            // Reset noise if player is not moving
            noise.m_AmplitudeGain = 0f;
            noise.m_FrequencyGain = 0f;
            virtualCamera.transform.localPosition = Vector3.SmoothDamp(virtualCamera.transform.localPosition, originalLocalPosition, ref velocity, smoothTime);
        }
    }
}
