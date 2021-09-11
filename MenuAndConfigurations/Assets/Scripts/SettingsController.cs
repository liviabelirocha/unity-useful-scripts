using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;


public class SettingsController : MonoBehaviour
{

    // Components
    [SerializeField] private Toggle fullScreenToggle;
    [SerializeField] private Dropdown resolutionDropdown;
    [SerializeField] private Dropdown graphicsDropdown;
    [SerializeField] private Slider soundVolumeSlider;

    private Resolution[] resolutions;
    private void OnEnable()
    {
        resolutions = Screen.resolutions;

        foreach (Resolution resolution in resolutions)
            resolutionDropdown.options.Add(new Dropdown.OptionData(resolution.ToString()));

        fullScreenToggle.onValueChanged.AddListener(delegate { OnFullScreenToggle(); });
        resolutionDropdown.onValueChanged.AddListener(delegate { OnResolutionChange(); });
        graphicsDropdown.onValueChanged.AddListener(delegate { OnGraphicsChange(); });
    }

    private void OnFullScreenToggle()
    {
        Screen.fullScreen = fullScreenToggle.isOn;
        OnResolutionChange();
    }

    private void OnResolutionChange()
    {
        Resolution resolution = resolutions[resolutionDropdown.value];
        Screen.SetResolution(resolution.width, resolution.height, fullScreenToggle.isOn);
    }

    private void OnGraphicsChange()
    {
        QualitySettings.SetQualityLevel(graphicsDropdown.value);
    }
}
