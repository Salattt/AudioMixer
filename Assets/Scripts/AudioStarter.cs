using UnityEngine;

[RequireComponent (typeof(AudioSource))]
public class AudioStarter : MonoBehaviour
{
    private AudioSource _audioSource;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void StartAudio()
    {
        _audioSource.time = 0;

        if(_audioSource.isPlaying == false)
            _audioSource.Play();
    }
}
