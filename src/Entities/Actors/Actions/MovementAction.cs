using Godot;
using System;

public partial class MovementAction : Action
{
    public Vector2I Offset { get; }

    public MovementAction(int dx, int dy)
    {
        Offset = new Vector2I(dx, dy);
    }
}