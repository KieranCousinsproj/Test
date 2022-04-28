using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExerciseInstruction
{
    //instruction field should contain a text description of the exercise or its common name
    private string instruction;
    //deviation is positive -> angle radial deviation, which is thumb towards forearm or negative -> Ulnar deviation, which is thumb away from forearm
    private double deviation;
    //flextend is flexion and extension positive flexion and negative extension
    private double flextend;
    //prosupination is postiive pronation->roll thumb down and negative supination-> roll thumb up 
    private double prosupination;
    //how long to hold the stretch at full range
    private double timer;
    //passive or active exercise
    private bool type;
    public ExerciseInstruction()
    {
        instruction = "";
        deviation = 0.0;
        flextend = 0.0;
        prosupination = 0.0;
    }


}
