using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SeasonManager : MonoBehaviour
{
    public GameObject menuPanel;
    public Button defaultButton; // Assign this in the Inspector to the Spring button (or whichever you want to be focused first)

    private Controls controls;

    private void Awake()
    {
        controls = new Controls();
        controls.UI.ToggleMenu.performed += ctx => ToggleMenu();
    }

    private void OnEnable()
    {
        controls.UI.Enable();
    }

    private void OnDisable()
    {
        controls.UI.Disable();
    }

    private void ToggleMenu()
    {
        if (menuPanel != null)
        {
            bool isActive = !menuPanel.activeSelf;
            menuPanel.SetActive(isActive);

            if (isActive && defaultButton != null)
            {
                // Focus the default button so Enter/Space works
                EventSystem.current.SetSelectedGameObject(defaultButton.gameObject);
            }
            else
            {
                // Clear the selection when hiding the menu
                EventSystem.current.SetSelectedGameObject(null);
            }
        }
    }

    public void LoadSpring()
    {
        SceneManager.LoadScene("Spring");
    }

    public void LoadSummer()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void LoadAutumn()
    {
        SceneManager.LoadScene("Autumn");
    }

    public void LoadWinter()
    {
        SceneManager.LoadScene("Winter");
    }
}
