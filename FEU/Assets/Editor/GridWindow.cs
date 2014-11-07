using UnityEngine;
using UnityEditor;
using System.Collections;

public class GridWindow : EditorWindow
{
	Grid grid;
	public GridEditor editor;

	public void Init()
	{
		grid = (Grid)FindObjectOfType(typeof(Grid));
	}

	void OnGUI()
	{
		grid.color = EditorGUILayout.ColorField(grid.color, GUILayout.Width(200));

		if (GUILayout.Button("Generate Tile Field", GUILayout.Width(255)))
		{   
			editor.GenerateTiles();
		} else if (GUILayout.Button("Destroy Tile Field", GUILayout.Width(255)))
		{   
			editor.DestroyTiles();
		}
	}

}