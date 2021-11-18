using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]

public class Audio_Material : MonoBehaviour
{
    public string SwitchGroup = "Ground Material";
    public string Switch = "Wood_Floor";
    public string ExitSwitch = "Grass";
    public GameObject Character;
    public bool Debug_Enabled;


    //public AK.Wwise.Switch Switch;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Player") { return; }
        if (Debug_Enabled) { Debug.Log(Switch + "switch set"); }
        AkSoundEngine.SetSwitch(SwitchGroup, Switch, Character);
    }

    private void OnTriggerExit(Collider other)
    {

        if (Debug_Enabled) { Debug.Log(ExitSwitch + "switch set"); }
        AkSoundEngine.SetSwitch(SwitchGroup, ExitSwitch, Character);

    }

}
