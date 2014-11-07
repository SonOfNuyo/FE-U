using UnityEditor;
using UnityEngine;

public static class WeaponExpList {
	
	public static void Show (SerializedProperty list) {
		
		list.arraySize = 12;
		EditorGUILayout.PropertyField(list);
		EditorGUI.indentLevel += 1;
		if (list.isExpanded) {
			for (int i = 0; i < list.arraySize; i++) {
				string newLabel = ((weaponTypes) i).ToString();
				
				EditorGUILayout.BeginHorizontal();
				EditorGUILayout.LabelField(newLabel);
				EditorGUILayout.PropertyField(list.GetArrayElementAtIndex(i), GUIContent.none);
				EditorGUILayout.EndHorizontal();
			}
		}
		EditorGUI.indentLevel -= 1;
		
	}
}