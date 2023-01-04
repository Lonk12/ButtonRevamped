using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Forms;

namespace TheButton.Button
{
    
    public partial class Window1 : Window
    {

        public Window1()
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
            System.IO.Stream a = Properties.Resources.RickAstley;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(a);
            player.Load();
            player.Play();
        
        }

    }

}