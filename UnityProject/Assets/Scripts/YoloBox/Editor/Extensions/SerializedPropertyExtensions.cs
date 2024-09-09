using UnityEditor;

namespace YoloBox.Editor {
  public static class SerializedPropertyExtensions {
    public static SerializedProperty FindAutoProperty(this SerializedObject serializedObject, string propertyName) {
      return serializedObject.FindProperty($"<{propertyName}>k__BackingField");
    }
  }
}
