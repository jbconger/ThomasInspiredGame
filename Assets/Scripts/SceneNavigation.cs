using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNavigation : MonoBehaviour
{
    public void ReloadScene()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

	public void TitleScene()
	{
		SceneManager.LoadScene("TitleScene");
	}	

	public void StartGame()
	{
		SceneManager.LoadScene("Level_1");
	}

	public void QuitGame()
	{
		Application.Quit();
	}
}
