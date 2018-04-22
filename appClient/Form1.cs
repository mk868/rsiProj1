using appClient.InfoManageService;
using appClient.InfoService;
using appClient.Models;
using rsiProj1.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appClient
{
    public partial class Form1 : Form
    {
        InfoServiceClient _infoServiceSoapClient;
        InfoManageServiceClient _infoManageServiceSoapClient;
        EventViewModel _eventDetails;
        public const string PdfFileName = "summary.pdf";

        public Form1()
        {
            InitializeComponent();

            _infoServiceSoapClient = new InfoServiceClient();
            _infoManageServiceSoapClient = new InfoManageServiceClient();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshEventList();
        }

        public void RefreshEventList()
        {
            listBox1.Items.Clear();

            List<EventListItemViewModel> events;

            if (radioButtonDay.Checked)
            {
                events = _infoServiceSoapClient.GetEventsForDay(dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            }
            else if (radioButtonWeekOfYear.Checked)
            {
                events = _infoServiceSoapClient.GetEventsForWeek(dateTimePicker1.Value.GetWeekOfYear(), dateTimePicker1.Value.Year);
            }
            else
            {
                return;
            }

            listBox1.Items.AddRange(events.Select(ev => new EventListItem(ev)).ToArray());
        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = listBox1.SelectedItem as EventListItem;

            if (item == null)
                return;

            LoadEventDetails(item.Event.Id.ToString());
        }

        private void LoadEventDetails(string eventId)
        {
            try
            {
                _eventDetails = _infoServiceSoapClient.GetEventById(eventId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (_eventDetails == null)
                return;

            labelId.Text = _eventDetails.Id.ToString();
            labelName.Text = _eventDetails.Name;
            labelDate.Text = _eventDetails.Date.ToString();
            labelType.Text = _eventDetails.TypeName;
            labelDescription.Text = _eventDetails.Description;
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public AdminHeader GetUserPassword()
        {
            var passwordForm = new PasswordForm();

            if (passwordForm.ShowDialog() != DialogResult.OK)
            {
                return null;
            }

            var header = new AdminHeader();
            header.Password = passwordForm.Password;
            return header;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (_eventDetails == null)
                return;

            var editForm = new EditForm();
            editForm.EventName = _eventDetails.Name;
            editForm.EventType = _eventDetails.TypeName;
            editForm.EventDate = _eventDetails.Date;
            editForm.EventDescription = _eventDetails.Description;

            while (editForm.ShowDialog() == DialogResult.OK)
            {
                var editModel = new EventEditViewModel();
                editModel.Id = _eventDetails.Id;
                editModel.Name = editForm.EventName;
                editModel.TypeName = editForm.EventType;
                editModel.Description = editForm.EventDescription;
                editModel.Date = editForm.EventDate.ToString();

                var header = GetUserPassword();
                if (header == null)
                    return;

                try
                {
                    _infoManageServiceSoapClient.EditEvent(header, editModel);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    continue;
                }

                MessageBox.Show("Saved");
                LoadEventDetails(_eventDetails.Id.ToString());
                RefreshEventList();
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_eventDetails == null)
                return;

            var header = GetUserPassword();
            if (header == null)
                return;

            try
            {
                _infoManageServiceSoapClient.RemoveEvent(header, _eventDetails.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            RefreshEventList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var editForm = new EditForm();

            while (editForm.ShowDialog() == DialogResult.OK)
            {
                var editModel = new EventAddViewModel();
                editModel.Name = editForm.EventName;
                editModel.TypeName = editForm.EventType;
                editModel.Description = editForm.EventDescription;
                editModel.Date = editForm.EventDate.ToString();

                var header = GetUserPassword();
                if (header == null)
                    return;

                try
                {
                    _infoManageServiceSoapClient.AddEvent(header, editModel);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    continue;
                }

                MessageBox.Show("Added");
                RefreshEventList();
                return;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            byte[] data;
            
            if (radioButtonDay.Checked)
            {
                data = _infoServiceSoapClient.GetPdfSummaryForDay(dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            }
            else if (radioButtonWeekOfYear.Checked)
            {
                data = _infoServiceSoapClient.GetPdfSummaryForWeek(dateTimePicker1.Value.GetWeekOfYear(), dateTimePicker1.Value.Year);
            }
            else
            {
                return;
            }

            File.WriteAllBytes(PdfFileName, data);
            System.Diagnostics.Process.Start(PdfFileName);
        }
    }
}
