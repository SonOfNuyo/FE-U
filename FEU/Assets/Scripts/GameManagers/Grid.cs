using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Grid : MonoBehaviour {

	public float width = 16.0f;
	public float height = 16.0f;

	public static int tileWidth;
	public static int tileHeight;

	public GameObject baseTile;
	public List<GameObject> tiles;

	public Color color = Color.white;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnDrawGizmos()
	{
		Gizmos.color = color;
		Vector3 pos = Camera.current.transform.position;

		if (height != 0f)
		for (float y = renderer.bounds.min.y; y < renderer.bounds.max.y; y+= height)
		{
			Gizmos.DrawLine(new Vector3(renderer.bounds.min.x, Mathf.Floor(y/height) * height, 0.0f),
			                new Vector3(renderer.bounds.max.x, Mathf.Floor(y/height) * height, 0.0f));
		}

		if (width != 0)
		for (float x = renderer.bounds.min.x; x <= renderer.bounds.max.x; x+= width)
		{
			Gizmos.DrawLine(new Vector3(Mathf.Floor(x/width) * width + width * .5f, renderer.bounds.min.y, 0.0f),
			                new Vector3(Mathf.Floor(x/width) * width + width * .5f, renderer.bounds.max.y, 0.0f));
		}

		/*if (height != 0 && width != 0) {
			for (float y = renderer.bounds.min.y; y < renderer.bounds.max.y - height; y+= height) {
				for (float x = renderer.bounds.min.x; x < renderer.bounds.max.x - width; x+= width) {
					Gizmos.DrawSphere(new Vector3(x + width*.5f, y + height * .5f, 0), .01f);
				}
			}
		}*/
	}

}
