using UnityEngine;
using UnityEngine.Events;

public class Goal : MonoBehaviour
{
	public static UnityEvent eventLevelEnd;

	private void Awake()
	{
		if (eventLevelEnd == null)
			eventLevelEnd = new UnityEvent();
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.CompareTag("Player"))
		{
			eventLevelEnd.Invoke();
		}
	}
}