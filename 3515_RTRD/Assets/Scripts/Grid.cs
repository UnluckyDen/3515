using UnityEngine;
using System.Collections;

public class Grid : MonoBehaviour {

	public int ID;
	public int item_id;
	public int icon_id;
	public bool active;

	public void SetID()
	{
		Inventory.grid_id = ID;
	}

	public void ResetID()
	{
		Inventory.grid_id = -1;
	}
}
