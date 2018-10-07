using MaterialSkin;
using System;

namespace ScriptHub
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e) => Admin.dopeadmin();

        private void materialRaisedButton2_Click(object sender, EventArgs e) => Admin.Elysian();

        private void materialRaisedButton3_Click(object sender, EventArgs e) => Admin.Fedora();

        private void materialRaisedButton4_Click(object sender, EventArgs e) => Admin.Pickles1();

        private void materialRaisedButton5_Click(object sender, EventArgs e) => Admin.PicklesS();

        private void materialRaisedButton6_Click(object sender, EventArgs e) => Admin.Pickles2();

        private void materialRaisedButton7_Click(object sender, EventArgs e) => Admin.Plasma();

        private void materialRaisedButton8_Click(object sender, EventArgs e) => Admin.Rocky();

        private void materialRaisedButton9_Click(object sender, EventArgs e) => Titan.Absalom();

        private void materialRaisedButton10_Click(object sender, EventArgs e) => Titan.Angel();

        private void materialRaisedButton11_Click(object sender, EventArgs e) => Titan.DarkMatter();

        private void materialRaisedButton12_Click(object sender, EventArgs e) => Titan.DarkT();

        private void materialRaisedButton13_Click(object sender, EventArgs e) => Titan.Deci();

        private void materialRaisedButton14_Click(object sender, EventArgs e) => Titan.Galenoir();

        private void materialRaisedButton15_Click(object sender, EventArgs e) => Titan.GodOfDestruction();

        private void materialRaisedButton16_Click(object sender, EventArgs e) => Titan.Mech();

        private void materialRaisedButton17_Click(object sender, EventArgs e) => Titan.Newer();

        private void materialRaisedButton18_Click(object sender, EventArgs e) => Titan.Ouga();

        private void materialRaisedButton19_Click(object sender, EventArgs e) => Titan.Pink();

        private void materialRaisedButton20_Click(object sender, EventArgs e) => Titan.Seigmund();

        private void materialRaisedButton21_Click(object sender, EventArgs e) => Titan.Spider();

        private void materialRaisedButton22_Click(object sender, EventArgs e) => Titan.Tachikito();

        private void materialRaisedButton23_Click(object sender, EventArgs e) => Titan.ThearkRulerv2();

        private void materialRaisedButton24_Click(object sender, EventArgs e) => Titan.White();

        private void materialRaisedButton25_Click_1(object sender, EventArgs e) => Boom.Allah();

        private void materialRaisedButton26_Click(object sender, EventArgs e) => Boom.Bomb();

        private void materialRaisedButton27_Click(object sender, EventArgs e) => Boom.Meteor();

        private void materialRaisedButton28_Click(object sender, EventArgs e) => Boom.Launcher();

        private void materialRaisedButton29_Click(object sender, EventArgs e) => Boom.Massive();

        private void materialRaisedButton30_Click(object sender, EventArgs e) => Boom.RPG();

        private void materialRaisedButton31_Click(object sender, EventArgs e) => Boom.Bomber();

        private void materialRaisedButton32_Click(object sender, EventArgs e) => Boom.Triggered();

    }
}
