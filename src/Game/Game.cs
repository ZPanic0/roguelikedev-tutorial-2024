using Godot;
using System;

public partial class Game : Node2D
{
    private Vector2I playerGridPos = Vector2I.Zero;
    private Sprite2D playerSprite;
    private EventHandler eventHandler;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        playerSprite = GetNode<Sprite2D>("Player");
        eventHandler = GetNode<Node>("EventHandler") as EventHandler;
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
    {
        var action = eventHandler.GetAction();

        if (action is MovementAction movementAction)
        {
            playerGridPos += movementAction.Offset;
            playerSprite.Position = Grid.ToWorld(playerGridPos);
        }
        else if (action is EscapeAction)
        {
            GetTree().Quit();
        }
    }
}
