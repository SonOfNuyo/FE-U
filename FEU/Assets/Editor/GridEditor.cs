using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor (typeof(Grid))]
public class GridEditor : Editor
{

	Grid grid;
	
	public void OnEnable()
	{
		grid = (Grid)target;
		SceneView.onSceneGUIDelegate = GridUpdate;
	}

	void GridUpdate(SceneView sceneview)
	{
		Event e = Event.current;

		Ray r = Camera.current.ScreenPointToRay(new Vector3(e.mousePosition.x, -e.mousePosition.y + Camera.current.pixelHeight));
		Vector3 mousePos = r.origin;
		
		if (e.isKey && e.character == 'a')
		{
			GameObject obj;
			Object prefab = PrefabUtility.GetPrefabParent(Selection.activeObject);
			
			if (prefab)
			{
				Undo.IncrementCurrentGroup();
				obj = (GameObject)PrefabUtility.InstantiatePrefab(prefab);
				Vector3 aligned = new Vector3(Mathf.Floor(mousePos.x/grid.width)*grid.width + grid.width,
				                              Mathf.Floor(mousePos.y/grid.height)*grid.height + grid.height * .5f, 0.0f);
				obj.transform.position = aligned;
				Undo.RegisterCreatedObjectUndo(obj, "Create " + obj.name);
			}
		}
		else if (e.isKey && e.character == 'd')
		{
			Undo.IncrementCurrentGroup();

			foreach (GameObject obj in Selection.gameObjects){
				Undo.RegisterCreatedObjectUndo(obj, "Delete Selected Objects");
			}
		}
	}
	
	public override void OnInspectorGUI()
	{
		GUILayout.BeginHorizontal();
		//GUILayout.Label(" Grid Tile: ");
		grid.baseTile = EditorGUILayout.ObjectField("Tile Object", grid.baseTile, typeof(GameObject), false) as GameObject;
		GUILayout.EndHorizontal();

		GUILayout.BeginHorizontal();
		GUILayout.Label(" Grid Width ");
		grid.width = EditorGUILayout.FloatField(grid.width, GUILayout.Width(50));
		GUILayout.EndHorizontal();

		GUILayout.BeginHorizontal();
		GUILayout.Label("Tile Width: " + Grid.tileWidth);
		GUILayout.Label("Tile Height: " + Grid.tileHeight);
		GUILayout.EndHorizontal();
		
		GUILayout.BeginHorizontal();
		GUILayout.Label(" Grid Height ");
		grid.height = EditorGUILayout.FloatField(grid.height, GUILayout.Width(50));
		GUILayout.EndHorizontal();
		
		if (GUILayout.Button("Open Grid Window", GUILayout.Width(255)))
		{   
			GridWindow window = (GridWindow) EditorWindow.GetWindow(typeof(GridWindow));
			window.Init();
			window.editor = this;
		}
		
		SceneView.RepaintAll();
	}

	public bool GenerateTiles(){
		
		//First create a tile holder
		GameObject g = new GameObject ();
		g.transform.parent = grid.gameObject.transform;
		g.name = "Tiles";

		int xCor = 1;
		int yCor = 1;
		//Generate a tile in the center of each grid square
		for (float y = grid.renderer.bounds.min.y; y < grid.renderer.bounds.max.y - grid.height; y+= grid.height) {
			xCor = 1;
			for (float x = grid.renderer.bounds.min.x; x < grid.renderer.bounds.max.x - grid.width; x+= grid.width) {
				
				if (grid.baseTile != null){
					GameObject o = PrefabUtility.InstantiatePrefab(grid.baseTile) as GameObject;
					o.transform.position = new Vector3 (x + grid.width * .5f, y + grid.height *.5f, 0f);
					o.transform.parent = g.transform;
					o.name = "Tile (" + xCor + ", " + yCor + ")";
					CoordStore c = o.GetComponent<CoordStore>();
					c.xCord = xCor;
					c.yCord = yCor;
					grid.tiles.Add(o);
				} else {
					return false;	//Failed
				}
				Grid.tileWidth = xCor++;
			}
			Grid.tileHeight = yCor++;
		}

		return true;
	}
	
	public void DestroyTiles(){
		for (int i = grid.tiles.Count - 1; i >= 0; i--) {
			if (grid.tiles[i] != null)
				DestroyImmediate(grid.tiles[i].gameObject);

			grid.tiles.RemoveAt(i);
			
		}
	}

}