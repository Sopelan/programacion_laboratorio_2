using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AdminPersonas
{
    class FrmVisorDataTable : frmVisorPersona
    {
        private DataTable dataTable;

        public FrmVisorDataTable(DataTable dataTable):base()
        {
            InitializeComponent();
            this.dataTable = dataTable;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                lstVisor.Items.Add(dataTable.Rows[i][0].ToString() + dataTable.Rows[i][1].ToString() + dataTable.Rows[i][2].ToString() + dataTable.Rows[i][3].ToString());
            }
        }

        public DataTable DataTable
        {
            get
            {
                return this.dataTable;
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FrmVisorDataTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(555, 271);
            this.Name = "FrmVisorDataTable";
            this.Load += new System.EventHandler(this.FrmVisorDataTable_Load);
            this.ResumeLayout(false);

        }

        private void FrmVisorDataTable_Load(object sender, EventArgs e)
        {

        }
    }
}
