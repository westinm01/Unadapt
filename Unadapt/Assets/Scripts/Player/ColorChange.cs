using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
	// Start is called before the first frame update
	public Color color1;
	public Color color2;
	public Color color3;
	public Color color4;
	public Color color5;
	public Color color6;

	private SpriteRenderer _spriteRenderer;

	[SerializeField] private AudioClip _colorChangeAudioClip;
	public AudioClip _ColorChangeAudioClip => this._colorChangeAudioClip;

	public void ChangeColor(Color color)
	{
		this._spriteRenderer.color = color;

		AudioPlayer.Instance.Play(audioClip: this._colorChangeAudioClip, type: AudioPlayer.Type.SoundEffect);
	}

	private void Start()
	{
		this._spriteRenderer = this.GetComponent<SpriteRenderer>();
		this._spriteRenderer.color = this.color1;
	}

	// Update is called once per frame
	private void Update()
	{

		if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
		{
			this.ChangeColor(this.color1);
		}
		else if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
		{
			this.ChangeColor(this.color2);
		}
		else if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3))
		{
			this.ChangeColor(this.color3);
		}
		else if (Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.Keypad4))
		{
			this.ChangeColor(this.color4);
		}
		else if (Input.GetKeyDown(KeyCode.Alpha5) || Input.GetKeyDown(KeyCode.Keypad5))
		{
			this.ChangeColor(this.color5);
		}
		else if (Input.GetKeyDown(KeyCode.Alpha6) || Input.GetKeyDown(KeyCode.Keypad6))
		{
			this.ChangeColor(this.color6);
		}
	}
}
