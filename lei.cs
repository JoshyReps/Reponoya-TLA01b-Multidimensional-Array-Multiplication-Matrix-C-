using Godot;
using System;

public partial class lei : Node
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		for (int i = 1; i <= 10; i++) 
		{
			String row = "";
		  	for (int j = 1; j <= 10; j++) 
			{
			  	row += i * j + " ";
			}
			GD.Print(row);
		}
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
