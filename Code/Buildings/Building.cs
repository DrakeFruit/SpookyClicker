using Sandbox;
using System;
using System.Linq;

public class Building
{
	public virtual string Ident => "none";
	public virtual string Name => "None";
	public virtual double Cost => 0;
	public virtual double PointsPerSecond => 0;

	public double GetCost( PlayerData playerData, ulong count )
	{
		var cost = Cost * Math.Pow( 1.1, count );
		return Math.Floor( cost );
	}

	public double GetPointsPerSecond( PlayerData playerData, ulong count )
	{
		return PointsPerSecond * count;
	}
}
