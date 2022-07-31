public AudioSource AudioSource;
public Slider volumeSlider;
private float MusicVolume = 1f;

void Start()
{
    AudioSource.Play();
    MusicVolume=Player.Prefs.GetFloat("volume");
    AudioSource.volume=MusicVolume;
    volumeSlider.value=MusicVolume;
}
// Update is called once per frame

void Update()
{
    AudioSource.volume= MusicVolume;
    PlayerPrefs.SetFloat("volume",MusicVolume);
}

public void VolumeUpdate(float volume)
{
    MusicVolume = volume;
}