using Godot;
using System;
using Php.Application;

public partial class Window : UxWindow
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		UxReady();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
