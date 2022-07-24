using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuView : View<PauseMenuView>
{
	public override void Open()
	{
		Time.timeScale = 0;

		base.Open();
	}

	public override void Close()
	{
		Time.timeScale = 1;

		base.Close();
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			if (this.Active_)
				this.Close();
			else
				this.Open();
		}
	}
}