using UnityEngine;
using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;

using NaughtyAttributes;

public class World : Core {

    [ShowAssetPreview]
    public GameObject obj;

    private NavMeshSurface2d surf;

    void Start(){

        surf = GetComponent<NavMeshSurface2d>();

    }

    void Update(){

        if ( Input.GetMouseButtonDown( 0 ) ){ BuildWall( obj ); }

        surf.BuildNavMesh();

    }

}