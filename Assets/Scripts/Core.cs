using UnityEngine;
using System.Collections;
using System.Collections.Generic;

interface coreInterface { int setTime(); }

public class Core : MonoBehaviour {

    static void setSpeed( ref int speed ){ speed = -2; }

    public float randomN( float min, float max ){ return Random.Range( min, max ); }

    public int randomN( int min, int max ){ return Random.Range( min, max ); }

    public void BuildWall( GameObject wall ){

        GameObject navMesh = GameObject.Find( "NavMesh" );

        Vector2 screenPosition = new Vector2( Input.mousePosition.x, Input.mousePosition.y );
        Vector3 target = Camera.main.ScreenToWorldPoint( screenPosition );
        target.z = -1;

        GameObject _obj = Instantiate( wall, target, Quaternion.identity, navMesh.transform );
        _obj.name = "Wall";

    }

    public Vector3 RandomPos( float x, float y ){

        Vector3 pos = new Vector3( 0, 0, -1 );

        pos.x = Random.Range( -x, x );
        pos.y = Random.Range( -y, y );

        return pos;

    }

    public void Mooving(){

        int speed = 0;
        setSpeed( ref speed );

        transform.position += transform.right * speed * Time.deltaTime;

    }

}