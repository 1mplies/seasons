using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Header("Rotation Settings")]
    public float dayDurationInSeconds = 60f; // Full cycle duration
    public Vector3 rotationAxis = Vector3.right; // Axis to rotate around

    public SkyboxSwitcher skyboxSwitcher; // Assign this in Inspector

    private float currentRotation = 0f;

    void Update()
    {
        // Calculate rotation amount this frame
        float anglePerSecond = 360f / dayDurationInSeconds;
        float rotationThisFrame = anglePerSecond * Time.deltaTime;

        // Rotate the sun (this GameObject)
        transform.Rotate(rotationAxis, rotationThisFrame);

        // Keep track of total rotation (0-360)
        currentRotation = (currentRotation + rotationThisFrame) % 360f;

        // Calculate normalized time (0-1)
        float normalizedTime = currentRotation / 360f;

        // Update skybox switcher with current time of day
        if (skyboxSwitcher != null)
        {
            skyboxSwitcher.SetTime(normalizedTime);
        }
    }
}
