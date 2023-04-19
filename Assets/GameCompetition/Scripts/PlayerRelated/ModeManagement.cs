using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeManagement : MonoBehaviour
{
    public enum Mode { Craft, Lumberjack }
    public Mode mode = Mode.Craft;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.mouseScrollDelta.y > 0) { mode = Mode.Craft; }
        if (Input.mouseScrollDelta.y < 0) { mode = Mode.Lumberjack; }

    }
}
