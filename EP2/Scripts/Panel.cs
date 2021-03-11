using Godot;
using System;

public class Panel : Godot.Panel
{
    Sprite sprite;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        sprite = GetNode<Sprite>("Sprite");

        GetNode("Button").Connect("pressed", this, nameof(OnButtonPressed));
    }

    // Called when we click the button
    public void OnButtonPressed()
    {
        Random random = new Random();

        int positionX = random.Next(1, 1024);
        int positionY = random.Next(1, 600);

        sprite.Position = new Vector2(positionX, positionY);

        GetNode<Label>("Label").Text = sprite.Position.ToString();
    }
}
