using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeSlider : MonoBehaviour
{
    [SerializeField] private Slider _slider;
     
    void Start()
    {
        _slider.onValueChanged.AddListener(value => SoundManager.Instance.ChangeMastervVolume(value));

    }
}
