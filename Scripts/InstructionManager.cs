using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionManager : MonoBehaviour
{
    public InstructionController[] instructionButtons;
    public GameObject[] instructionPrefabs;
    public GameObject[] ItemImage;
    public int currentButtonPressed;

    private void update()
    {
        Vector2 worldPosition = GetMousePos();
        Debug.Log("button pressed" + currentButtonPressed);
        if(Input.GetMouseButtonDown(0) && instructionButtons[currentButtonPressed].clicked)
        {
            instructionButtons[currentButtonPressed].clicked = false;
            Instantiate(instructionPrefabs[currentButtonPressed], new Vector3(worldPosition.x, worldPosition.y, 0), Quaternion.identity);
            Destroy(GameObject.FindWithTag("ItemImage"));
        }
        Vector3 mousePos = Input.mousePosition;
        {
            Debug.Log(mousePos.x);
            Debug.Log(mousePos.y);
        }
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
    public int getID(string name)
    {
        int i = 0,result = 0;
        string[] exercises = { "Flex", "Extend", "RollInPronation", "RollOutSupination", "RadialDev", "UlnarDev" };
        foreach(string s in exercises)
        {
            if (s==name)
            {
                result = i;
            }
        }
        return result;
    }
}
