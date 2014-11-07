using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Class))]
public class ClassEditor : Editor {
	
	public override void OnInspectorGUI () {
		
		serializedObject.Update();
		EditorGUILayout.PropertyField(serializedObject.FindProperty("className"), true);
		EditorGUILayout.PropertyField(serializedObject.FindProperty("level"), true);
		EditorGUILayout.PropertyField(serializedObject.FindProperty("moveType"), true);
		EditorGUILayout.PropertyField(serializedObject.FindProperty("bonuses"), true);
		WeaponProfList.Show(serializedObject.FindProperty("weaponFoci"));
		EditorGUILayout.PropertyField(serializedObject.FindProperty("promotionPaths"), true);
		serializedObject.ApplyModifiedProperties();
		
	}
	
}
