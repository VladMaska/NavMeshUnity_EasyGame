using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface wallInterface { int setTime(); }

public class Wall : Core, wallInterface {

    public int setTime(){ return 15; }
    
    void Start(){

        Destroy( this.gameObject, setTime() );
        
    }

    void Update(){

        Mooving();
        
    }

}