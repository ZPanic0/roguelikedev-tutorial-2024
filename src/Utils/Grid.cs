using Godot;
using System;

public static class Grid
{
    private static readonly Vector2I tileSize = new(16, 16);
    public static Vector2I ToWorld(Vector2I gridPosition)
    {
        return gridPosition * tileSize;
    }

    public static Vector2I ToGrid(Vector2I worldPosition)
    {
        return worldPosition / tileSize;
    }
}
