using UnityEngine;

public class SeasonSwitcher : MonoBehaviour
{
    public GameObject summerEnvironment;
    public GameObject winterEnvironment;

    private bool isSummer = true;

    void Start()
    {
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
    }
}