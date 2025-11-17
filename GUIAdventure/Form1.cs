using System.Runtime.InteropServices;

namespace GUIAdventure
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int mode = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            trackBar1.Visible = false;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mode == 0)
            {
                this.Close();
            }
            else if (mode == 1) //for warrior
            {
                mode = 2;
                label1.Text = "What a strong warrior! \n Do you use a sword or an axe?";
                button1.BackColor = Color.Silver;
                button1.Text = "Look at my sharp sword";
                button2.BackColor = Color.BurlyWood;
                button2.Text = "See how heavy my axe is";
            }
            else if (mode == 2) //for sword
            {
                label1.Text = "Show me the power of your sword!";
                trackBar1.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
            }
            else if (mode == 3) //for fire
            {
                label1.Text = "Show me the power of your fire!";
                trackBar1.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (mode == 0)
            {
                mode = 1;
                label1.Text = "Are you a warrior or a wizard?";
                button1.Text = "Feel my brute strength";
                button2.Text = "Fear my strategic spells";
            }
            else if (mode == 1) //for wizard
            {
                mode = 3;
                label1.Text = "Such a powerful wizard! \n What´s your element of choice?";
                button1.BackColor = Color.Red;
                button1.Text = "My spirit burns bright";
                button2.BackColor = Color.LightBlue;
                button2.Text = "I will freeze you in place";
            }
            else if (mode == 2) //for axe
            {
                label1.Text = "Show me the power of your axe!";
                trackBar1.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
            }
            else if (mode == 3) //for ice
            {
                label1.Text = "Show me the power of your ice!";
                trackBar1.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }
    }
}
