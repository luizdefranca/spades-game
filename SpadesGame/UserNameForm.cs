using SpadesLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpadesGame
{
    public partial class UserNameForm : Form
    {
        private String playerName;
        private TableForm tableForm;
        public UserNameForm()
        {
            InitializeComponent();
        }

        public UserNameForm(TableForm tableForm)
        {
            InitializeComponent();
            tableForm = this.tableForm;

        }

        private void buttonName_Click(object sender, EventArgs e) => tableForm.playerName = textName.Text;
    }
}
