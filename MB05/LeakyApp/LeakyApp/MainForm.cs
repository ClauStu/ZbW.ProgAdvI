using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeakyApp {
    public partial class MainForm : Form {
        List<ClockForm> clockForms = new();

        public MainForm() {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e) {
            for (int i = 0; i < 50; i++) {
                var clockForm = new ClockForm();
                clockForm.Show();
                clockForms.Add(clockForm);
            }
        }

        private void Stop_Click(object sender, EventArgs e) {
            foreach (var clockForm in clockForms) {
                clockForm.Close();
            }

            clockForms.Clear();

            GC.Collect();
        }
    }
}
