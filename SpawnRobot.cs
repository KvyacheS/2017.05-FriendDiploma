using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRobot : MonoBehaviour {
    public GameObject Robot;
    //public GameObject GameContr
    GameObject txt;
    bool placed=false;
    // Use this for initialization
    private void OnMouseDown()
    {
        if (!placed)
        {
            txt = GameObject.Find("EnergyText");
            // GameObject suns = GameObject.Find("SunCollect");

            if (GameObject.Find("Main Camera").GetComponent<SelectRobot>().Robot != null)
            {
                Robot = GameObject.Find("Main Camera").GetComponent<SelectRobot>().Robot.GetComponent<RobotType>().robot;
                if ((Robot != null) && (GameController.CurResources - GameObject.Find("Main Camera").GetComponent<SelectRobot>().Robot.GetComponent<RobotType>().price >= 0))
                {
                    GameController.CurResources -= GameObject.Find("Main Camera").GetComponent<SelectRobot>().Robot.GetComponent<RobotType>().price;
                    GameObject.Find("Main Camera").GetComponent<SelectRobot>().Robot.GetComponent<RobotType>().Deselect();
                    txt.GetComponent<GUIText>().text = GameController.CurResources.ToString();
                    Instantiate(Robot,
                            transform.position + Robot.GetComponent<UnitOffset>().offset,
                            Quaternion.identity, GameObject.Find("DynamicObjects").transform );
                    GameObject.Find("Main Camera").GetComponent<SelectRobot>().Robot = null;
                    placed = true;
                }
            }
        }
    }
}
