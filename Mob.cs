using Godot;
using System;

public partial class Mob : PathFollow2D
{
    [Export]
    public float Speed;

    public Mob() {}

    public override void _Process(double delta)
    {
        Progress += (float)delta * Speed;
    }
}
