using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioMultiSceneLoop : MonoBehaviourSingleton<AudioMultiSceneLoop>
{
	[SerializeField] private string _destructionSceneName = "[Scene] Main Menu";
	public string _DestructionSceneName => this._destructionSceneName;

	private void OnSceneLoaded(Scene scene, LoadSceneMode loadSceneMode)
	{
		if (scene.name == this._destructionSceneName)
			Object.Destroy(this.gameObject);
	}

	protected override void Awake()
	{
		base.Awake();

		SceneManager.sceneLoaded += this.OnSceneLoaded;
	}

	private void OnDestroy()
	{
		SceneManager.sceneLoaded -= this.OnSceneLoaded;
	}
}