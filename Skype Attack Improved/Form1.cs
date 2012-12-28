using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skype_Attack_Improved {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            SKYPE4COMLib.Skype skype = new SKYPE4COMLib.Skype();
            String[] friends = new String[skype.Friends.Count];
            for (int i = 1; i <= skype.Friends.Count; i++) {
                friends[i - 1] = skype.Friends[i].Handle;
            }
            Array.Sort(friends);
            for (int i = 0; i < friends.Length; i++) {
                comboBox1.Items.Add(friends[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            SKYPE4COMLib.Skype attacker = new SKYPE4COMLib.Skype();
            String sendto = comboBox1.Text;
            String msg = textBox2.Text; 
            int count = Convert.ToInt32(textBox3.Text);
            for (int i = 1; i <= count; i++) {
                attacker.SendMessage(sendto, msg);
            }
        }
    }
}
