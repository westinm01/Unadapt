using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
	public enum Type
	{
		Ambience,
		Music,
		SoundEffect,
		Narrative
	}

	[System.Serializable]
	public class Data
	{
		[SerializeField] private AudioPlayer.Type _type;
		public AudioPlayer.Type _Type => this._type;

		[SerializeField] private AudioSource _audioSource;
		public AudioSource _AudioSource => this._audioSource;
	}

	[SerializeField] private Data[] _data;
	public Data[] _Data => this._data;

	public void Play(AudioClip audioClip, Type type)
	{
	}
}