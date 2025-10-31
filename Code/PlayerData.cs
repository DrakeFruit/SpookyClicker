using System;
using System.Collections.Generic;
using System.IO.Enumeration;
using Sandbox;
using System.Linq;
using Sandbox.Services;

public class PlayerData
{
	public int Score { get; set; }

	public void Save()
	{
		FileSystem.Data.WriteJson("player.json", this );
		Stats.SetValue( "score", Score );
	}

	public PlayerData Load()
	{
		var save = FileSystem.Data.ReadAllText( "player.json" );
		if ( save == null )
		{
			return new PlayerData();
		}
		return Json.Deserialize<PlayerData>( save );
	}
}
