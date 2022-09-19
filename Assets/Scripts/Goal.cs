using UnityEngine;

public class Goal : MonoBehaviour
{
	[SerializeField] WinObserver winObserver;

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.CompareTag("Player"))
		{
			winObserver.OnLevelWin.Invoke();
		}
	}
}