using UnityEngine;

public class SeasonSwitcher : MonoBehaviour
{
    public GameObject springEnvironment;
    public GameObject summerEnvironment;
    public GameObject autumnEnvironment;
    public GameObject winterEnvironment;

    public Material springSkybox;
    public Material summerSkybox;
    public Material autumnSkybox;
    public Material winterSkybox;

    private enum Season { Spring, Summer, Autumn, Winter }
    private Season currentSeason = Season.Spring;

    void Start()
    {
        RenderSettings.fog = true;
        SetSeason(currentSeason);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            // cycle through seasons
            currentSeason = (Season)(((int)currentSeason + 1) % 4);
            SetSeason(currentSeason);
        }
    }

    void SetSeason(Season season)
    {
        springEnvironment.SetActive(season == Season.Spring);
        summerEnvironment.SetActive(season == Season.Summer);
        autumnEnvironment.SetActive(season == Season.Autumn);
        winterEnvironment.SetActive(season == Season.Winter);

        switch (season)
        {
            case Season.Spring:
                RenderSettings.fogDensity = 0.005f;
                RenderSettings.fogColor = new Color(0.6f, 0.8f, 0.6f); // soft greenish fog
                RenderSettings.skybox = springSkybox;
                break;
            case Season.Summer:
                RenderSettings.fogDensity = 0.003f;
                RenderSettings.fogColor = new Color(0.9f, 0.9f, 0.9f); // light, bright fog
                RenderSettings.skybox = summerSkybox;
                break;
            case Season.Autumn:
                RenderSettings.fogDensity = 0.005f;
                RenderSettings.fogColor = new Color(0.9f, 0.7f, 0.4f); // warm orange fog
                RenderSettings.skybox = autumnSkybox;
                break;
            case Season.Winter:
                RenderSettings.fogDensity = 0.018f;
                RenderSettings.fogColor = new Color(0.8f, 0.85f, 0.9f); // cold bluish fog
                RenderSettings.skybox = winterSkybox;
                break;
        }

    }
}
