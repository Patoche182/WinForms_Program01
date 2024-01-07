namespace WinForms_Program01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vous avez un message !", "Titre box", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
        }
    }
}
