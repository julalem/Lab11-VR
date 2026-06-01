using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class HoverHighlight : MonoBehaviour
{
	private Renderer rend;
	private Color originalColor;
	public Color highlightColor = Color.yellow;

	void Start()
	{
		rend = GetComponent<Renderer>();
		originalColor = rend.material.color;

		var interactable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable>();
		interactable.hoverEntered.AddListener(_ => rend.material.color = highlightColor);
		interactable.hoverExited.AddListener(_ => rend.material.color = originalColor);
	}
}