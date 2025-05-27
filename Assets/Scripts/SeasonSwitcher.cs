using UnityEngine;

public class SeasonSwitcher : MonoBehaviour
{
    public GameObject summerEnvironment;
    public GameObject winterEnvironment;

    private bool isSummer = true;

    void Start()
    {
        // Enable fog at start and set to summer level
        RenderSettings.fog = true;
        SetSeason(true);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            isSummer = !isSummer;
            SetSeason(isSummer);
        }
    }

    void SetSeason(bool summer)
    {
        summerEnvironment.SetActive(summer);
        winterEnvironment.SetActive(!summer);

        if (!summer)
        {
            RenderSettings.fogDensity = 0.015f; // winter fog density
            RenderSettings.fogColor = new Color(0.8f, 0.85f, 0.9f); // light bluish fog
        }
        else
        {
            RenderSettings.fogDensity = 0.003f; // summer fog density (very low)
            RenderSettings.fogColor = new Color(0.9f, 0.9f, 0.9f); // lighter fog color
        }
    }
}
