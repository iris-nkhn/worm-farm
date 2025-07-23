using Godot;
using System;

public partial class Drawer : Window
{
    public override void _Ready()
    {
        var switch_nest = GetNode<BaseButton>("switch_nest");
        switch_nest.Toggled += OnSwitchNestToggled;
       

    }

    private void OnSwitchNestToggled(bool toggledOn)
    {
        Visible = !Visible;
        
    }


    private void OnSwitchNestToggled()
    {
        

    }
    

}
