using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
	public void LoadScene(int sceneBuildIndex) => SceneManager.LoadScene(sceneBuildIndex: sceneBuildIndex, mode: LoadSceneMode.Single);
	public void LoadScene(string sceneName) => SceneManager.LoadScene(sceneName: sceneName, mode: LoadSceneMode.Single);

	public void Exit() => Application.Quit();
}