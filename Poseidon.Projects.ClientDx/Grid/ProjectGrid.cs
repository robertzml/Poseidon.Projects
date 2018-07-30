using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poseidon.Projects.ClientDx
{
    using Poseidon.Base.System;
    using Poseidon.Common;
    using Poseidon.Winform.Base;
    using Poseidon.Projects.Core.DL;
    using Poseidon.Projects.Core.Utility;

    /// <summary>
    /// 项目表格控件
    /// </summary>
    public partial class ProjectGrid : WinEntityGrid<Project>
    {
        #region Constructor
        public ProjectGrid()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Event
        /// <summary>
        /// 格式化数据显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvEntity_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            int rowIndex = e.ListSourceRowIndex;
            if (rowIndex < 0 || rowIndex >= this.bsEntity.Count)
                return;

            //var list = this.bsEntity.DataSource as List<Project>;
            if (e.Column.FieldName == "Type")
            {
                e.DisplayText = ((ProjectType)e.Value).DisplayName();
            }
        }
        #endregion //Event
    }
}
