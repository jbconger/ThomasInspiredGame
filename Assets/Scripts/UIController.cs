using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
	[SerializeField] GameObject overlay;

	private void Start()
	{
		Goal.eventLevelEnd.AddListener(EnableOverlay);
	}

	public void EnableOverlay()
	{
		overlay.SetActive(true);
	}

	public void DisableOverlay()
	{
		overlay.SetActive(false);
	}
}
