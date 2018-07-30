using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Projects.Core.Utility
{
    /// <summary>
    /// 项目类型
    /// </summary>
    public enum ProjectType
    {
        /// <summary>
        /// 工程类
        /// </summary>
        [Display(Name = "工程类")]
        Engineering = 1,

        /// <summary>
        /// 货物类
        /// </summary>
        [Display(Name = "货物类")]
        Cargo = 2,

        /// <summary>
        /// 服务类
        /// </summary>
        [Display(Name = "服务类")]
        Service = 3
    }
}
