
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioClipPlayback : MonoBehaviour
{
	[SerializeField] private AudioClip _audioClip;
	public AudioClip _AudioClip => this._audioClip;

	[SerializeField] private AudioPlayer.Type _type;
	public AudioPlayer.Type _Type => this._type;

	[SerializeField] private bool _loop;
	public bool _Loop => this._loop;

	[SerializeField] private bool _multiScene;
	public bool _MultiScene => this._multiScene;

	private void Start()
	{
		AudioSource audioSource = AudioPlayer.Instance.Play(
			audioClip: this._audioClip,
			type: this._type,
			loop: this._loop
		);

		if (this._multiScene)
			audioSource.gameObject.AddComponent<AudioMultiSceneLoop>();
	}
}