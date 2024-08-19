using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioMixerUpdater : MonoBehaviour
{
    [SerializeField] private AudioMixer _audioMixer;
    [SerializeField] private Slider _masterVolume;
    [SerializeField] private Slider _musicVolume;
    [SerializeField] private Slider _sampleVolume;

    private void Update()
    {
        _audioMixer.SetFloat(Constants.Master, Mathf.Log10(Mathf.Max(float.Epsilon, _masterVolume.value)) * 20);
        _audioMixer.SetFloat(Constants.Music, Mathf.Log10(Mathf.Max(float.Epsilon, _musicVolume.value)) * 20);
        _audioMixer.SetFloat(Constants.Sample, Mathf.Log10(Mathf.Max(float.Epsilon, _sampleVolume.value)) * 20);
    }
}
