using Editor.Util;
using UnityEditor; 
using UnityEngine; 
using System.Collections; 

/// <summary>
/// Grid editor.
/// This class, takes variables from another class that you want to edit. 
/// </summary>
/// n
namespace Editor.Grid
{
[CustomEditor(typeof(GridBehavior))]
public class GridEditor:EditorBase<GridBehavior>
{
	public override void OnInspectorGUI()
	{
		//This is where you create your target, by script. 
		GridBehavior targetScript = (GridBehavior)target; 
		//To create a GUI element for each variable. 
		targetScript.theMapLength = EditorGUILayout.IntSlider("Map Length",targetScript.theMapLength, 1, 30); 
		targetScript.theMapWidth = EditorGUILayout.IntSlider("Map Width", targetScript.theMapWidth, 1, 30); 
		//targetScript.booleanVariable = EditorGUILayout.Toggle("Bool", targetScript.booleanVariable); 
		targetScript.theMovePointPrehab = EditorGUILayout.ObjectField("Movepoint", targetScript.theMovePointPrehab, typeof(MovePointBehavior), true) as MovePointBehavior; 
		
		if(GUILayout.Button("Call Function"))
			targetScript.CreateGrid(); 
	}
}
}