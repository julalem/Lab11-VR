using UnityEngine;
using UnityEngine.InputSystem;

public class ColorChanger : MonoBehaviour
{
	public InputActionReference primaryButtonAction;
	public GameObject targetObject;

	private Renderer targetRenderer;
	private bool isRed = false;

	void Start()
	{
		if (targetObject != null)
			targetRenderer = targetObject.GetComponent<Renderer>();
	}

	void OnEnable()
	{
		primaryButtonAction.action.performed += OnPrimaryButton;
		primaryButtonAction.action.Enable();
	}

	void OnDisable()
	{
		primaryButtonAction.action.performed -= OnPrimaryButton;
	}

	void OnPrimaryButton(InputAction.CallbackContext ctx)
	{
		if (targetRenderer == null) return;
		isRed = !isRed;
		targetRenderer.material.color = isRed ? Color.red : Color.white;
	}
}