using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlidersContainer : MonoBehaviour
{
	private VolumeSlider[] _volumeSliders;

	public void RefreshVisuals()
	{
		for (int a = 0; a < this._volumeSliders.Length; a++)
		{
			this._volumeSliders[a].RefreshVisuals();
		}
	}

	private void Awake()
	{
		this._volumeSliders = this.GetComponentsInChildren<VolumeSlider>();
	}
}