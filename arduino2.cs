using Godot;
using System;
using System.IO.Ports;

public partial class arduino2 : Node2D
{

	SerialPort serialPort;
	RichTextLabel text;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
