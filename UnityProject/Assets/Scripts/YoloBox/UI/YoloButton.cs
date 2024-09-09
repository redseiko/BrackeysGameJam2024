using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace YoloBox {
  public sealed class YoloButton : Button {
    [field: SerializeField]
    public UnityEvent<PointerEventData> OnPointerDownClick { get; private set; }

    public override void OnPointerDown(PointerEventData eventData) {
      base.OnPointerDown(eventData);

      OnPointerDownClick.Invoke(eventData);
    }
  }
}
