using Godot;
using System;

public partial class MobSpawner : Node
{
    [Export]
    public PackedScene MobScene { get; set; }
    [Export]
    public Timer MobTimer { get; set; }
    [Export]
    public Path2D MobPath { get; set; }

    public override void _Ready() {
        if (MobTimer != null) {
            MobTimer.Start();
        } else {
            GD.PrintErr("MobTimer is not assigned in the Inspector!");
        }
    }

    private void SpawnMob() {
        if (MobScene == null) {
            GD.PrintErr("MobScene is not assigned in the Inspector!");
            return;
        }

        if (MobPath == null) {
            GD.PrintErr("MobPath is not assigned in the Inspector!");
            return;
        }

        PathFollow2D mob = MobScene.Instantiate<PathFollow2D>();
        MobPath.AddChild(mob);
    }
}
