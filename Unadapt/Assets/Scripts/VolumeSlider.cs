using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class VolumeSlider : MonoBehaviour
{
	private Slider _slider;

	[SerializeField] private AudioVolumeSettings _audioVolumeSettings;
	public AudioVolumeSettings _AudioVolumeSettings => this._audioVolumeSettings;

	public void RefreshVisuals()
	{
		this._slider.value = this._audioVolumeSettings.Volume;
	}

	private void Awake()
	{
		this._slider = this.GetComponent<Slider>();

		this._slider.onValueChanged.AddListener(
			call: (value) =>
			{
				this._audioVolumeSettings.Volume = value;
			}
		);
	}
}