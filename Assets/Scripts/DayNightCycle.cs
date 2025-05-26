using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Header("Rotation Settings")]
    public float dayDurationInSeconds = 60f; // Full cycle duration
    public Vector3 rotationAxis = Vector3.right; // Axis to rotate around

    void Update()
    {
        float anglePerSecond = 360f / dayDurationInSeconds;
        transform.Rotate(rotationAxis, anglePerSecond * Time.deltaTime);
    }
}