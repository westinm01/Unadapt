using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioPlayer : MonoBehaviourSingleton<AudioPlayer>
{
	public enum Type
	{
		Ambience,
		Music,
		Narrative,
		SoundEffect,
	}

	[System.Serializable]
	public class Data
	{
		[SerializeField] private AudioPlayer.Type _type;
		public AudioPlayer.Type _Type => this._type;

		[SerializeField] private AudioVolumeSettings _audioVolumeSettings;
		public AudioVolumeSettings _AudioVolumeSettings => this._audioVolumeSettings;

		[SerializeField] private AudioSource _audioSource;
		public AudioSource _AudioSource => this._audioSource;
	}

	private Dictionary<int, Data> _type_data_relations;

	public AudioSource Play(AudioClip audioClip, Type type, bool loop = false)
	{
		Data data = this._type_data_relations[(int)type];

		AudioSource audioSource = Object.Instantiate(data._AudioSource);

		audioSource.clip = audioClip;
		audioSource.volume = data._AudioVolumeSettings.Volume;
		data._AudioVolumeSettings.OnVolumeChange += (value) =>
		{
			audioSource.volume = value;
		};
		audioSource.loop = loop;

		audioSource.Play();

		if (!loop)
			Object.Destroy(audioSource, audioClip.length);

		return audioSource;
	}

	[SerializeField] private Data[] _data;
	public Data[] _Data => this._data;

	protected override void Awake()
	{
		base.Awake();

		this._type_data_relations = new Dictionary<int, Data>(this._data.Length);

		for (int a = 0; a < this._data.Length; a++)
		{
			this._type_data_relations.Add(key: (int)this._data[a]._Type, value: this._data[a]);
		}

		SceneManager.sceneLoaded += (scene, mode) =>
		{
			for (int a = 0; a < this._data.Length; a++)
			{
				this._data[a]._AudioVolumeSettings.OnVolumeChange = delegate { };
			}
		};
	}
}