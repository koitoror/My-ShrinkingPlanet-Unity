using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager instance;

	public GameObject gameOverUI;

	void Awake ()
	{
		instance = this;
		
		// Limit FPS to minimum of 30
		Application.targetFrameRate = 30;
	}

	public void EndGame ()
	{
		gameOverUI.SetActive(true);
	}

	public void Restart ()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

}
