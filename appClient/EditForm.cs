using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appClient
{
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
        }

        public string EventName
        {
            get => this.textBoxName.Text;
            set => this.textBoxName.Text = value;
        }

        public string EventType
        {
            get => this.textBoxType.Text;
            set => this.textBoxType.Text = value;
        }

        public string EventDescription
        {
            get => this.textBoxDescription.Text;
            set => this.textBoxDescription.Text = value;
        }

        public DateTime EventDate
        {
            get => this.dateTimePickerDate.Value;
            set => this.dateTimePickerDate.Value = value;
        }

        private void EditForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
