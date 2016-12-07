using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ReloadLevel : MonoBehaviour {

	public GameObject player;
	public GameObject table;
    public Text activation;
    public static bool hackStarted = false;
    private bool activated = false;
    private Vector3 pos1 = new Vector3 (0, 100, 0);
    private Vector3 origin = new Vector3 (0, 0, 0);
    

	bool computer_range (GameObject player, GameObject computer)
    {
		if (player.transform.position.x > (computer.transform.position.x + -0.22f)
		    && player.transform.position.x < (computer.transform.position.x + 1.5f)
		    && player.transform.position.z > (computer.transform.position.z + -1.2f)
		    && player.transform.position.z < (computer.transform.position.z + 1.24f))
			return true;
		else
			return false;
    }

    void Start ()
    {
        activation.text = "";
    }

	void Update ()
	{
        if (Input.GetKeyDown(KeyCode.R))
        {
            activated = false;
	        hackStarted = false;

	    if (!hackStarted)
	        Debug.Log("hackStarted is false");
             
            player.transform.position = origin;
            player.transform.rotation = Quaternion.identity;
        }

        if (computer_range (player, table) && !activated)
        {
            activation.text = "Press \"F\" to initiate hack";
            if (Input.GetKeyDown (KeyCode.F))
            {
                activated = true;
                player.transform.position = pos1;
                hackStarted = true;

		if (hackStarted)
		    Debug.Log("hackStarted is true");
            }
        }
        else
            activation.text = "";
	}
}
