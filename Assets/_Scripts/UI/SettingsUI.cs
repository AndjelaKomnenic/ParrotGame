using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio; 
using System.Collections.Generic;


public class SettingsUI : MonoBehaviour
{
    [Header("Graphics Settings")]
    public Dropdown resolutionDropdown;
    public Toggle fullscreenToggle;

    [Header("Audio Settings")]
    public AudioMixer audioMixer; 
    public Slider masterVolumeSlider;
    public Slider musicVolumeSlider;
    public Slider sfxVolumeSlider;

    [Header("Gameplay Settings")]
    public Toggle invertYToggle;

    [Header("Buttons")]
    public Button applyButton;
    public Button cancelButton;

    private Resolution[] resolutions;

    private void Start()
    {
        LoadAvailableResolutions();
        LoadCurrentSettings();
    }

    private void LoadAvailableResolutions()
    {
        resolutions = Screen.resolutions;
        resolutionDropdown.ClearOptions();

        List<string> options = new List<string>();
        int currentResolutionIndex = 0;

        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);

            if (resolutions[i].width == Screen.width && resolutions[i].height == Screen.height)
            {
                currentResolutionIndex = i;
            }
        }

        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
    }

    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

    public void SetMasterVolume(float volume)
    {
        audioMixer.SetFloat("MasterVolume", volume);
    }

    public void SetMusicVolume(float volume)
    {
        audioMixer.SetFloat("MusicVolume", volume);
    }

    public void SetSFXVolume(float volume)
    {
        audioMixer.SetFloat("SFXVolume", volume);
    }

    public void SetInvertY(bool isInverted)
    {
    }

    public void ApplySettings()
    {
    }

    public void CancelChanges()
    {
        LoadCurrentSettings();
    }

    private void LoadCurrentSettings()
    {
    }

}
