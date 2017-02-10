using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatMaster
{
    public partial class NewGame : Form
    {
        public NewGame()
        {
            InitializeComponent();
        }

        private void NewGame_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'statMasterDBDataSet.Champions' table. You can move, or remove it, as needed.
            this.championsTableAdapter.Fill(this.statMasterDBDataSet.Champions);
            
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            //string connection = StatMaster.StatMasterDBDataSet;
            int gridSelected = int.Parse(dataGridView1.SelectedRows.ToString());
            //SqlDataAdapter da = new SqlDataAdapter(new SqlCommand("SELECT ChampionID, ChampionImage FROM Champions WHERE ChampionID = " + gridSelected.ToString(), StatMasterDBDataSet.))
            ChampImage.Rows[gridSelected].Selected = true;
            
            ChampImage.Columns["ChampionImage"].Frozen = true;
            
        }
    }
}
