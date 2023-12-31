using System.Collections;
using System.Collections.Generic;

using UnityEngine;

//This script extends the enemy class
public class Enemy_1 : Enemy
{
    static public Enemy_1 S; 

    [Header("Set in Inspector: Enemy_1")]

    // number of seconds for a full sine wave
    public float waveFrequency = 2;

    // sine wave width in meters
    public float waveWidth = 4;
    public float waveRotY = 45;

    private float x0;
    private float birthTime;

    //Start works well because it's not used by the Enemy superclass
    void Start()
    {
        //set x0 to the intitial x position of Enemy_1
        x0 = pos.x;

        birthTime = Time.time;
    }

    //override the Move function on Enemy 
    public override void Move()
    {
        //Because pos is a propert, you can't directly set pos.x
        //so you instead get the pos as an editbale Vector3
        Vector3 tempPos = pos;

        //theta adjusts based on time
        float age = Time.time - birthTime;
        float theta = Mathf.PI * 2 * age / waveFrequency;
        float sin = Mathf.Sin(theta);
        tempPos.x = x0 + waveWidth * sin;
        pos = tempPos;

        //Rotate a bit about y
        Vector3 rot = new Vector3(0, sin * waveRotY, 0);
        this.transform.rotation = Quaternion.Euler(rot);

        //base.Move() still handles the movement down in y
        base.Move();

        //print (bnd.Check.isOnScreen);
    }
	
}
