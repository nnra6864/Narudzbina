using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Narudzbina
{
    
    public partial class Porudzbina : Form
    {
        BindingList<string> shownPredjela = new BindingList<string>();
        BindingList<string> shownJela = new BindingList<string>();
        BindingList<string> shownDeserti = new BindingList<string>();

        public Porudzbina()
        {
            InitializeComponent();
            AddFood();
            comBoxPredjelo.DataSource = shownPredjela;
            comBoxJelo.DataSource = shownJela;
            comBoxDesert.DataSource = shownDeserti;
        }

        public void AddFood()
        {
            DayOfWeek dayOfWeek = DateTime.Today.DayOfWeek;
            Jela jela = new Jela();
            List<Jela> listaJela = new List<Jela>();

            string _path = "TextFiles/Menu.txt";
            File.ReadAllText(_path);

            List<string> lines = File.ReadAllLines(_path).ToList();
            foreach (string line in lines) 
            {
                string[] entries = line.Split(',');

                if (entries[0] == dayOfWeek.ToString())
                {
                    jela.predjelo.Add(entries[1]);
                    jela.jelo.Add(entries[2]);
                    jela.desert.Add(entries[3]);

                    listaJela.Add(jela);
                }
            }

            foreach (string pjel in jela.predjelo)
            {
                shownPredjela.Add(pjel);
            }

            foreach (string jel in jela.jelo)
            {
                shownJela.Add(jel);
            }

            foreach (string des in jela.desert)
            {
                shownDeserti.Add(des);
            }
        }

        private void Porudzbina_MouseDown(object sender, MouseEventArgs e)
        {

        }


        #region Buttons
        private void pbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void btnPoruci_Click(object sender, EventArgs e)
        {
            string selectedPredjelo = comBoxPredjelo.SelectedItem.ToString();
            string selectedJelo = comBoxJelo.SelectedItem.ToString();
            string selectedDesert = comBoxDesert.SelectedItem.ToString();

            StreamWriter sw = new StreamWriter("TextFiles/Porudzbina.txt");

            sw.WriteLine(selectedPredjelo);
            sw.WriteLine(selectedJelo);
            sw.WriteLine(selectedDesert);

            sw.Close();

            Poruci poruci = new Poruci();
            poruci.ShowDialog();
        }
    }
}