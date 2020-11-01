using System.Windows.Forms;
using Microsoft.VisualBasic;
class UsingIDemo
{
    static void Main()
    {
        MessageBoxIcon icon;
        string msg, title, name;
        name=Interaction.InputBox(
        "Как Вас зозут?",
        "Знакомимся");
        if (name == "")
        {
            icon = MessageBoxIcon.Error;
            msg = "Очень жаль, что мы не познакомились!";
            title = "3накомство не состоялось";
        }
        else
        {
            icon=MessageBoxIcon.Information; 
            msg = "Очень приятно, " + name + "!";
            title = "Знакомство состоялось";
        }
        MessageBox.Show(msg, title, MessageBoxButtons.OK, icon);
    }
}
