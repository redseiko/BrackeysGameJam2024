using Coffee.UIEffects;

using TMPro;

using UnityEngine;
using UnityEngine.UI;

namespace GameJam {
  public sealed class LabelButton : MonoBehaviour {
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
  }
}
