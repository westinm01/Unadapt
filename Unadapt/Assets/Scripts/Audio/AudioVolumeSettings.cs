using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "[Audio Volume Settings]", menuName = "[Audio Volume Settings]")]
public class AudioVolumeSettings : ScriptableObject
{
	public System.Action<float> OnVolumeChange;

	[Range(0.0f, 1.0f)]
	[SerializeField] private float _volume;
	public float Volume
	{
		get => this._volume;
		set
		{
			this._volume = value;

			this.OnVolumeChange?.Invoke(this._volume);
		}
	}
}