using UnityEngine;

public class Music : MonoBehaviour
{
    private AudioSource _audioSource;
    public static bool mute;
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        _audioSource = GetComponent<AudioSource>();
    }
	private void Update()
	{
		if (mute)
		{
            _audioSource.mute = true;

        } else
		{
            _audioSource.mute = false;

        }
	}

	public void PlayMusic()
    {
        if (_audioSource.isPlaying) return;
        _audioSource.Play();
    }

    public void StopMusic()
    {
        _audioSource.Stop();
    }
}