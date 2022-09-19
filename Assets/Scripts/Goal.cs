using UnityEngine;
using UnityEngine.Events;

public class Goal : MonoBehaviour
{
	UnityEvent eventLevelEnd;
	[SerializeField] GameObject winOverlay;
	[SerializeField] GameObject playerObject;

	private void Awake()
	{
		if (eventLevelEnd == null)
			eventLevelEnd = new UnityEvent();

		eventLevelEnd.AddListener(DisablePlayerInput);
		eventLevelEnd.AddListener(DisplayWinOverlay);
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.CompareTag("Player"))
		{
			eventLevelEnd.Invoke();
		}
	}

	private void DisablePlayerInput()
	{
		playerObject.GetComponent<PlayerController>().enabled = false;
		playerObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
	}

	private void DisplayWinOverlay()
	{
		winOverlay.SetActive(true);
	}
}