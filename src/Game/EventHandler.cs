using Godot;
using System;

public partial class EventHandler : Node
{
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
    {
    }

    public Action GetAction()
    {
        if (Input.IsActionJustPressed("ui_up"))
        {
            return new MovementAction(0, -1);
        }
        else if (Input.IsActionJustPressed("ui_down"))
        {
            return new MovementAction(0, 1);
        }
        else if (Input.IsActionJustPressed("ui_left"))
        {
            return new MovementAction(-1, 0);
        }
        else if (Input.IsActionJustPressed("ui_right"))
        {
            return new MovementAction(1, 0);
        }
        else if (Input.IsActionJustPressed("ui_cancel"))
        {
            return new EscapeAction();
        }
        else { return null; }
    }
}
