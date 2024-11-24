using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    private static BackgroundMusic instance;
    public bool soundEnabled = true;

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        if (soundEnabled)
        {
            GetComponent<AudioSource>().Play();
        }
    }

    public void ToggleSound()
    {
        soundEnabled = !soundEnabled;
        if (soundEnabled)
        {
            GetComponent<AudioSource>().Play();
        }
        else
        {
            GetComponent<AudioSource>().Stop();
        }
    }
}
