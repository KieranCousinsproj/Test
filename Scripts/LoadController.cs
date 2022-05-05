using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadController : MonoBehaviour
{
    public InstructionManager manager;
    // Start is called before the first frame update
    void Start()
    {
        List<Instruction> loadList = GameData.current.getInstructionList();
        foreach(Instruction ins in loadList)
        {
            Instantiate(manager.instructionPrefabs[ins.ID], getPos(ins), Quaternion.identity);
        }
    }
    private Vector3 getPos(Instruction ins)
    {
        return new Vector3(ins.getX(), ins.getY(), 0);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
