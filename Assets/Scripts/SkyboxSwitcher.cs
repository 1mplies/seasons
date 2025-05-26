using UnityEngine;

public class SkyboxSwitcher : MonoBehaviour
{
    public Material daySkybox;
    public Material nightSkybox;

    [Range(0f, 1f)]
    public float timeOfDay; // 0 = day start, 0.5 = night, 1 = next day

    void Update()
    {
        if (timeOfDay >= 0.47f)
        {
            RenderSettings.skybox = nightSkybox;
        }
        else
        {
            RenderSettings.skybox = daySkybox;
        }

        DynamicGI.UpdateEnvironment(); // Refresh the skybox lighting
    }


    // Optional: method to update timeOfDay from other scripts
    public void SetTime(float normalizedTime)
    {
        timeOfDay = Mathf.Clamp01(normalizedTime);
        Debug.Log("Time: " + timeOfDay);

    }
}
