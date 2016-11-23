using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1
{
    public partial class AddEditPosition : Form
    {
        DBHelper db = new DBHelper();
        private int position_id;
        public AddEditPosition(int position_id)
        {
            InitializeComponent();
            this.position_id = position_id;

            if (position_id != 0)
            {
                GetPositionData(position_id);
            }
        }

        private void GetPositionData(int position_id)
        {
            var result = db.getSinglePosition(this.position_id)[0];
            textBox_description.Text = result.Description.TrimEnd();
            textBox_name.Text = result.Name.TrimEnd();
            textBox_hourfee.Text = result.Hour_fee.ToString();
        }

        private void savePositionButton_Click(object sender, EventArgs e)
        {
            Position position = new Position();
            position.Name = textBox_name.Text;
            position.Description = textBox_description.Text;
            position.Hour_fee = int.Parse(textBox_hourfee.Text);
            if (position_id == 0)
            {
                db.addPosition(position, 0);
            }
            else
            {
                db.editPosition(position, position_id);
            }
            this.Close();
        }

        private void cancelPositionButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddEditPosition_Activated(object sender, EventArgs e)
        {
            if (position_id != 0)
            {
                GetPositionData(position_id);
            }
        }
    }
}
