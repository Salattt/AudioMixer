using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioMutter : MonoBehaviour
{
    [SerializeField] private List<AudioSource> _audioSources;

    private bool _isMutted = false;

    public void ChangeMuteCondition()
    {
        _isMutted = !_isMutted;

        foreach (AudioSource source in _audioSources)
        { 
            source.mute = _isMutted;
        }
    }
}
