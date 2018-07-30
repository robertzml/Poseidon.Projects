﻿using System;
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
    using Poseidon.Base.System;
    using Poseidon.Common;
    using Poseidon.Winform.Base;
    using Poseidon.Projects.Core.BL;
    using Poseidon.Projects.Core.DL;

    /// <summary>
    /// 新增项目窗体
    /// </summary>
    public partial class FrmProjectAdd : BaseSingleForm
    {
        #region Constructor
        public FrmProjectAdd()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 输入检查
        /// </summary>
        /// <returns></returns>
        private Tuple<bool, string> CheckInput()
        {
            string errorMessage = "";

            if (string.IsNullOrEmpty(this.txtName.Text.Trim()))
            {
                errorMessage = "名称不能为空";
                return new Tuple<bool, string>(false, errorMessage);
            }
            if (string.IsNullOrEmpty(this.txtNumber.Text.Trim()))
            {
                errorMessage = "项目号不能为空";
                return new Tuple<bool, string>(false, errorMessage);
            }
            if (string.IsNullOrEmpty(this.txtPrincipal.Text.Trim()))
            {
                errorMessage = "负责人不能为空";
                return new Tuple<bool, string>(false, errorMessage);
            }
            if (this.dpEstablishDate.EditValue == null)
            {
                errorMessage = "请选择立项日期";
                return new Tuple<bool, string>(false, errorMessage);
            }

            return new Tuple<bool, string>(true, "");
        }

        /// <summary>
        /// 设置实体
        /// </summary>
        /// <param name="entity"></param>
        private void SetEntity(Project entity)
        {
            entity.Name = this.txtName.Text;
            entity.Number = this.txtNumber.Text;
            entity.ShortName = this.txtShortName.Text;
            entity.EstablishDate = this.dpEstablishDate.DateTime;
            entity.Principal = this.txtPrincipal.Text;
            entity.DatasetCode = this.txtDatasetCode.Text;
            entity.Remark = this.txtRemark.Text;
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var input = CheckInput();
            if (!input.Item1)
            {
                MessageUtil.ShowError(input.Item2);
                return;
            }

            try
            {
                Project entity = new Project();
                SetEntity(entity);

                BusinessFactory<ProjectBusiness>.Instance.Create(entity);

                MessageUtil.ShowInfo("保存成功");
                this.Close();
            }
            catch (PoseidonException pe)
            {
                Logger.Instance.Exception("新增项目失败", pe);
                MessageUtil.ShowError(string.Format("保存失败，错误消息:{0}", pe.Message));
            }
        }
        #endregion //Event
    }
}
