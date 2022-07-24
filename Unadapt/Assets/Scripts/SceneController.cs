using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
	public void LoadScene(int sceneBuildIndex)
	{
		Time.timeScale = 1;

		SceneManager.LoadScene(sceneBuildIndex: sceneBuildIndex, mode: LoadSceneMode.Single);
	}

	public void LoadScene(string sceneName)
	{
		Time.timeScale = 1;

		SceneManager.LoadScene(sceneName: sceneName, mode: LoadSceneMode.Single);
	}

	public void LoadCurrentScene()
	{
		Time.timeScale = 1;

		SceneManager.LoadScene(sceneBuildIndex: SceneManager.GetActiveScene().buildIndex, mode: LoadSceneMode.Single);
	}

	public void LoadNextScene()
	{
		Time.timeScale = 1;

		SceneManager.LoadScene(sceneBuildIndex: SceneManager.GetActiveScene().buildIndex + 1, mode: LoadSceneMode.Single);
	}

	public void Exit() => Application.Quit();
}