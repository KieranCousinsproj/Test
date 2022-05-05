using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Instruction
{
    //instruction field should contain a text description of the exercise or its common name
    private string instruction;
    //deviation is positive -> angle radial deviation, which is thumb towards forearm or negative -> Ulnar deviation, which is thumb away from forearm
    private double range;
    //how long to hold the stretch at full range
    private double timer;
   
    //position in scene
    private float gridRank;
    //x pos
    private float xPos;
    //which exercise
    public int ID;

    public Instruction()
    {
        this.instruction = "";
        this.range = 0.0;
        this.timer = 0.0;
        this.gridRank = 1;
        this.xPos = 0.0f;
    }
    public Instruction(string comment, double angle, double length,float inGridRank,float inXpos,int inID)
    {
        this.instruction = comment;
        this.range = angle;
        this.timer = length;
        this.gridRank = inGridRank;
        this.xPos = inXpos;
        this.ID = inID;
    }
    public void setGridRank(int inGridRank)
    {
        this.gridRank = inGridRank;
    }
    public float getGridRank()
    {
        return this.gridRank;
    }
    public float getX()
    {
        return xPos;
    }
    public float getY()
    {
        return ((gridRank - getX())/10000) - 10000;
    }
}
