using UnityEditor;
using UnityEditor.UI;

using UnityEngine;

namespace YoloBox.Editor {
  [CustomEditor(typeof(YoloButton))]
  public sealed class YoloButtonEditor : ButtonEditor {
    SerializedProperty _onPointerDownClickProperty;

    protected override void OnEnable() {
      base.OnEnable();
      _onPointerDownClickProperty = serializedObject.FindAutoProperty(nameof(YoloButton.OnPointerDownClick));
    }

    public override void OnInspectorGUI() {
      base.OnInspectorGUI();

      serializedObject.Update();

      EditorGUILayout.Space();
      EditorGUILayout.PropertyField(_onPointerDownClickProperty);

      serializedObject.ApplyModifiedProperties();
    }
  }
}
