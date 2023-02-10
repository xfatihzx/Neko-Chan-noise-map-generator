using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(MapGenerator))]
public class MapGeneratorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        MapGenerator mapGenerator = (MapGenerator)target;

        if (DrawDefaultInspector() && mapGenerator.autoUpdate)
        {
            mapGenerator.GenerateMap();
        }

        if (GUILayout.Button("Paw paw Nyann"))
        {
            mapGenerator.GenerateMap();
        }
    }
}
