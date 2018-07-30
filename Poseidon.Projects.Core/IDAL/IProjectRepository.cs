using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Projects.Core.IDAL
{
    using Poseidon.Base.Framework;
    using Poseidon.Projects.Core.DL;

    /// <summary>
    /// 项目数据访问接口
    /// </summary>
    internal interface IProjectRepository : IBaseDAL<Project>
    {
    }
}
