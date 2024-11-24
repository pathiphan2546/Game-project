using UnityEngine;
using UnityEngine.UI;
public class PlayButtonSound : MonoBehaviour
{
    public AudioSource sound;

    public void PlaySound()
    {
        sound.Play();
    }

    private void Awake() {
        DontDestroyOnLoad(sound);
    }
}