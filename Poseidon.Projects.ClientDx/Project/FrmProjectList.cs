using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poseidon.Projects.ClientDx
{
    using Poseidon.Base.Framework;
    using Poseidon.Winform.Base;
    using Poseidon.Projects.Core.BL;

    /// <summary>
    /// 项目列表窗体
    /// </summary>
    public partial class FrmProjectList : BaseMdiForm
    {
        #region Constructor
        public FrmProjectList()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        protected override void InitForm()
        {
            LoadData();

            base.InitForm();
        }

        private void LoadData()
        {
            var data = BusinessFactory<ProjectBusiness>.Instance.FindAll();
            this.projectGrid.DataSource = data.ToList();
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 新增项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ChildFormManage.ShowDialogForm(typeof(FrmProjectAdd));

            LoadData();
        }
        #endregion //Event
    }
}
