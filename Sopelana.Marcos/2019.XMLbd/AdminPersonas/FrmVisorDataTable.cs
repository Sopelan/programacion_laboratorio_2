using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using System.Data.SqlClient;
using AdminPersonas;
namespace AdminPersonas
{
    public partial class FrmVisorDataTable : frmVisorPersona
    {
        private DataTable dataTable;
        public FrmVisorDataTable(DataTable dataTable):base()
        {
            InitializeComponent();
            this.dataTable = dataTable;
            for(int i = 0; i < dataTable.Rows.Count;i++ )
            {
                lstVisor.Items.Add(dataTable.Rows[i][0].ToString() + dataTable.Rows[i][1].ToString() + dataTable.Rows[i][2].ToString() + dataTable.Rows[i][3].ToString());
            }
            
        }
        public DataTable DataTable { get { return dataTable; } }

        private void FrmVisorDataTable_Load(object sender, EventArgs e)
        {

        }

        private void lstVisor_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
