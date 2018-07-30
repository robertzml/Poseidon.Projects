using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Projects.Core.DL
{
    using Poseidon.Base.Framework;

    /// <summary>
    /// 项目类
    /// </summary>
    public class Project : ObjectEntity
    {
        #region Property
        /// <summary>
        /// 项目号
        /// </summary>
        [Display(Name = "项目号")]
        public string Number { get; set; }

        /// <summary>
        /// 简称
        /// </summary>
        [Display(Name = "简称")]
        public string ShortName { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [Display(Name = "类型")]
        public int Type { get; set; }

        /// <summary>
        /// 立项日期
        /// </summary>
        [Display(Name = "立项日期")]
        public DateTime EstablishDate { get; set; }

        /// <summary>
        /// 负责人
        /// </summary>
        [Display(Name = "负责人")]
        public string Principal { get; set; }

        /// <summary>
        /// 项目状态
        /// </summary>
        [Display(Name = "项目状态")]
        public int State { get; set; }

        /// <summary>
        /// 数据集代码
        /// </summary>
        [Display(Name = "数据集代码")]
        public string DatasetCode { get; set; }
        #endregion //Property
    }
}
