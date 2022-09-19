using UnityEngine;
using UnityEngine.Events;

public class WinObserver : MonoBehaviour
{
    [HideInInspector] public UnityEvent OnLevelWin;

	[SerializeField] GameObject WinOverlay;
	[SerializeField] PlayerController playerController;

	private void Awake()
	{
		if (OnLevelWin == null)
			OnLevelWin = new UnityEvent();

		OnLevelWin.AddListener(ActivateWinOverlay);
	}

	private void ActivateWinOverlay()
	{
		WinOverlay.SetActive(true);
		playerController.enabled = false;
		playerController.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
	}
}