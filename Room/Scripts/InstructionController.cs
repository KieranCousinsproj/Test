using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstructionController : MonoBehaviour
{
    private List<string> InstructionList = new List<string>();
    public Text instructionText;
    public void buttonUpPressed()
    {
        InstructionList.Add("UP");
    }
    public void buttonDownPressed()
    {
        InstructionList.Add("DOWN");
    }
    public void buttonLeftPressed()
    {
        InstructionList.Add("LEFT");
    }
    public void buttonRightPressed()
    {
        InstructionList.Add("RIGHT");
    }
    public void buttonSpacePressed()
    {
        InstructionList.Add("SPACE");
    }
    private string getInstructionList()
    {
        string val  = string.Join(", ", InstructionList.ToArray());
        return val;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        instructionText.text = getInstructionList();
    }
}
