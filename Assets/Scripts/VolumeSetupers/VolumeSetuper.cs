using UnityEngine;
using UnityEngine.Audio;

public class VolumeSetuper : MonoBehaviour
{
    [SerializeField] private SliderHandler _sliderHandler;
    [SerializeField] private AudioMixer _audioMixer;

    protected string _volumeName;

    private void OnEnable()
    {
        _sliderHandler.OnValueChanged += SetupVolume;
    }

    private void OnDisable()
    {
        _sliderHandler.OnValueChanged -= SetupVolume;
    }

    private void SetupVolume(float volume)
    {
        _audioMixer.SetFloat(_volumeName, CalculateVolume(volume));
    }

    private float CalculateVolume(float volume)
    {
        float volumeFactor = 20;

        return Mathf.Log10(Mathf.Max(float.Epsilon, volume)) * volumeFactor;
    }
}
