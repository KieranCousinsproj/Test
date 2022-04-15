using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InstructionController : MonoBehaviour
{

    // Note this is for right hand, left hand is opposite for roll and yaw 

    private List<string> TextList = new List<string>();
    public Text instructionText;
    public void buttonFlexPressed()
    {
        TextList.Add("FLEX WRIST");
    }
    public void buttonExtPressed()
    {
        TextList.Add("EXTEND WRIST");
    }
    public void buttonSupPressed()
    {
        TextList.Add("ROLL WRIST RIGHT");
    }
    public void buttonPronPressed()
    {
        TextList.Add("ROLL WRIST LEFT");
    }
    public void buttonRadDevPressed()
    {
        TextList.Add("TILT WRIST LEFT");
    }
    public void buttonUlnDevPressed()
    {
        TextList.Add("TILT WRIST RIGHT");
    }
    private string getInstructionList()
    {
        string val  = string.Join(", ", TextList.ToArray());
        return val;
    }
    // Start is called before the first frame update
    void Start()
    {
        TextList = GameData.current.getInstructionList();
    }
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("OfflineScene");

    }
    // Update is called once per frame
    void Update()
    {
        instructionText.text = getInstructionList();
    }
    private void save()
    {
        List<string> newList = new List<string>();
        foreach (string ele in TextList)
        {
            newList.Add(ele);
        }
        GameData.current.setInstructionList(newList);
        SaveLoad.Save();
    }
}
