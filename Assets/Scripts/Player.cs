using UnityEngine;
using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;

using WhiteWolf;

public class Player : Core {

    public Vector3 point;

    float time, timer = 2.5f;
    private NavMeshAgent agent;

    DataBase db = new DataBase();

    void Start(){

        agent = this.gameObject.GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;

        point.x = db.LoadDataFloat( "x" );
        point.y = db.LoadDataFloat( "y" );
        
    }

    void Update(){

        time += Time.deltaTime;

        if ( time >= timer ){

            point = RandomPos( 13, 5 );
            time = 0;
            db.SaveDataFloat( "x", point.x );
            db.SaveDataFloat( "y", point.y );

        }
        else if ( transform.position.x == point.x && transform.position.y == point.y ){

            point = RandomPos( 13, 5 );
            time = 0;
            db.SaveDataFloat( "x", point.x );
            db.SaveDataFloat( "y", point.y );

        }
        else agent.SetDestination( point ); // Move
        
    }

}