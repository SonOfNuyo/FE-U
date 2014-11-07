using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(ProficiencyManager))]
public class WeaponProfsEditor : Editor {
	
	public override void OnInspectorGUI () {

		serializedObject.Update();
		WeaponProfList.Show(serializedObject.FindProperty("weaponProfs"));
		WeaponExpList.Show(serializedObject.FindProperty("weaponExp"));
		EditorGUILayout.PropertyField(serializedObject.FindProperty("SRankWeapon"), true);
		serializedObject.ApplyModifiedProperties();

	}
	
}
