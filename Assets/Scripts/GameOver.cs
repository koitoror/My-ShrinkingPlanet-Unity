using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

    private Control controlInput;

    private void Awake()
    {
        controlInput = new Control();
    }

    private void OnEnable()
    {
        controlInput.Enable();
    }

    private void OnDisable()
    {
        controlInput.Disable();
    }
    void Update ()
	{
		if (controlInput.Player.Jump.triggered)
		{
			GameManager.instance.Restart();
		}

		GetComponent<RectTransform>().localScale = Vector3.one * Planet.Size;
	}

	public void Menu ()
	{
		SceneManager.LoadScene("Menu");
	}

}
