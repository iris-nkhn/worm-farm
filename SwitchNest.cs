using Godot;
using System;

public partial class SwitchNest : CheckButton
{
    void OnSwitchNestToggled()
    {
        Visible = !Visible;

    }

}
