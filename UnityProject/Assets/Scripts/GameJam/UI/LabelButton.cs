using Coffee.UIEffects;

using DG.Tweening;

using TMPro;

using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

using YoloBox;

namespace GameJam {
  public sealed class LabelButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {
    [field: Header("Container")]
    [field: SerializeField]
    public RectTransform RectTransform { get; private set; }

    [field: Header("Background")]
    [field: SerializeField]
    public Image BackgroundImage { get; private set; }

    [field: SerializeField]
    public UIGradient BackgroundGradient { get; private set; }

    [field: Header("Label")]
    [field: SerializeField]
    public TextMeshProUGUI Label { get; private set; }

    Sequence _onHoverTween;

    private void Start() {
      CreateTweens();
    }

    void CreateTweens() {
      _onHoverTween =
          DOTween.Sequence()
              .Insert(0f, Label.rectTransform.DOBlendableScaleBy(Vector3.one * 0.05f, 0.5f))
              .SetLink(gameObject)
              .SetAutoKill(false)
              .SetUpdate(true)
              .Pause();
    }

    public void OnPointerEnter(PointerEventData eventData) {
      _onHoverTween.PlayAgain();
    }

    public void OnPointerExit(PointerEventData eventData) {
      _onHoverTween.SmoothRewind();
    }
  }
}
