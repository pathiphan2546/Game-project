using UnityEngine;
using UnityEngine.UI;

public class SoundToggle : MonoBehaviour
{
    public Toggle soundToggle;

    private const string SoundEnabledKey = "SoundEnabled";

    private void Start()
    {
        soundToggle.onValueChanged.AddListener(ToggleSound);

        bool soundEnabled = PlayerPrefs.GetInt(SoundEnabledKey, 1) == 1;
        soundToggle.isOn = soundEnabled;

        ToggleSound(soundEnabled);
    }

    private void ToggleSound(bool value)
    {
        BackgroundMusic backgroundMusic = FindObjectOfType<BackgroundMusic>();
        backgroundMusic.soundEnabled = value;
        AudioSource audioSource = backgroundMusic.GetComponent<AudioSource>();
        if (value)
        {
            audioSource.Pause();
        }
        else
        {
            audioSource.UnPause();
        }

    
        PlayerPrefs.SetInt(SoundEnabledKey, value ? 1 : 0);
        PlayerPrefs.Save();
    }
}

