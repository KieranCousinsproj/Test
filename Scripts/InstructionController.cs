using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Text;

public class InstructionController : MonoBehaviour
{
    public int ID;
    public bool clicked = false;
    private InstructionManager manager;

    void start()
    {
        manager = GameObject.FindWithTag("InstructionManager").GetComponent<InstructionManager>();
    }

    public void buttonClicked()
    {
        Debug.Log("button pressed");
        Vector2 worldPosition = GetMousePos();
        clicked = true;
        Instantiate(manager.ItemImage[ID], new Vector3(worldPosition.x, worldPosition.y, 0), Quaternion.identity);
        manager.currentButtonPressed = ID;
    }
   
    /*private string getInstructionList()
    {
        string val  = string.Join(", ", TextList.ToArray());
        return val;
    }
    // Start is called before the first frame update
    void Start()
    {
        TextList = GameData.current.getInstructionList();
    }*/
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("OfflineScene");

    }
    // Update is called once per frame
    void Update()
    {
       
    }
    Vector3 GetMousePos()
    {
        Debug.Log(Input.mousePosition);
        Vector3 screenPosDepth = Input.mousePosition;
        // Give it a depth. Maybe a raycast depth, maybe a clipping plane...
        screenPosDepth.z = 697.78f;
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(screenPosDepth);
        mousePos.z = 0;
        return mousePos;
    }
}
