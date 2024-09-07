using UnityEngine;
using UnityEngine.InputSystem;

namespace GameJam {
  public sealed class InputManager : MonoBehaviour {
    [field: SerializeField]
    public PlayerInput PlayerInputRef { get; private set; }

    [field: SerializeField]
    public InputActionReference InteractAction { get; private set; }

    private void Awake() {
      InteractAction.action.performed += OnInteractAction;
    }

    public void OnInteractAction(InputAction.CallbackContext context) {
      if (context.performed) {
        Debug.Log($"Interact was pressed. {context.action.name} - {context.action.id} - {context.phase}");
      }
    }

    public void OnButtonClick() {
      Debug.Log("Button was clicked.");
    }
  }
}
