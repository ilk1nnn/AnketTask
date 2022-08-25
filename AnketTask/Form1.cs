using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Newtonsoft.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AnketTask
{
    public partial class Form1 : Form
    {

        List<User> users = new List<User>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void JsonSerialize(List<User>user)
        {
            var serializer = new JsonSerializer();
            string fileName = filenametxtb.Text + ".json";

            using (var sw = new StreamWriter(fileName))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Formatting.Indented;
                    serializer.Serialize(jw, user);
                }
            }
        }

        public void JsonDeserialize()
        {
            var serializer = new JsonSerializer();
            string fileName = filenametxtb.Text + ".json";
            using (var sr = new StreamReader(fileName))
            {
                using (var jr = new JsonTextReader(sr))
                {
                    users = serializer.Deserialize<List<User>>(jr);
                }
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            User user = new User(nametxtb.Text,surnametxtb.Text,emailtxtb.Text,phonetxtb.Text);
            users.Add(user);
            nametxtb.Text = String.Empty;
            surnametxtb.Text = String.Empty;
            emailtxtb.Text = String.Empty;
            phonetxtb.Text = String.Empty;
            listBox.Items.Add(user.Name);
        }

        private void load_btn_Click(object sender, EventArgs e)
        {
            JsonDeserialize();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            JsonSerialize(users);
        }
    }
}
