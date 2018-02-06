using System.Linq;
using UnityEngine;

public class SmartParthenon : MonoBehaviour {

    public GameObject cubePrefab, cylinderPrefab, floorMaterial, pillarMaterial, roofMaterial;
    public float floor_width = 5.0f;
    public float floor_depth = 10.0f;
    public float floor_height = 0.25f;
    public float pillar_radius = 0.2f;
    public float pillar_height = 2.0f;
    public float pillar_countwidth = 6.0f;
    public float pillar_countdepth = 10.0f;
    public float roof_height = 1.0f;
    
    [ContextMenu("Build")]
    void Build()
    {
        foreach(Transform t in transform.Cast<Transform>().ToArray())
            DestroyImmediate(t.gameObject);
        
        var floor1 = Instantiate(cubePrefab, transform);
        floor1.transform.localPosition = new Vector3(0, 0, 0);
        floor1.transform.localScale = new Vector3(floor_width, floor_height, floor_depth);

        var floor2 = Instantiate(cubePrefab, transform);
        floor2.transform.localPosition = new Vector3(0, floor_height, 0);
        floor2.transform.localScale = new Vector3(floor_width*0.9f, floor_height, floor_depth*0.9f);

        var floor3 = Instantiate(cubePrefab, transform);
        floor3.transform.localPosition = new Vector3(0, floor_height*2, 0);
        floor3.transform.localScale = new Vector3(floor_width * 0.81f, floor_height, floor_depth * 0.81f);

        var pillar = Instantiate(cylinderPrefab, transform);
        pillar.transform.localPosition = new Vector3(floor_width * 0.81f / 2.0f - pillar_radius, floor_height*2.5f + pillar_height/2, floor_depth * 0.81f / 2.0f - pillar_radius);
        pillar.transform.localScale = new Vector3(pillar_radius*2, pillar_height/2, pillar_radius*2);
        
    }
}
