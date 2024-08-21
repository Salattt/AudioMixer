using UnityEngine;
using UnityEngine.Audio;

public class AudioMutter : MonoBehaviour
{
    [SerializeField] private AudioMixer _audioMixer;

    private bool _isMutted = false;
    private float _lastVolume;
    private float _volumeFactor = 20;

    public void ChangeMuteCondition()
    {
        _isMutted = !_isMutted;

        if (_isMutted)
        {
            _audioMixer.GetFloat(Constants.Master, out float volume);

            _lastVolume = volume;

            _audioMixer.SetFloat(Constants.Master, Mathf.Log10(float.Epsilon * _volumeFactor));
        }
        else
        {
            _audioMixer.SetFloat(Constants.Master, _lastVolume);
        }
    }
}
