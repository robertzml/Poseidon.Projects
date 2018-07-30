using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Projects.Core.BL
{
    using Poseidon.Base.Framework;
    using Poseidon.Projects.Core.DL;
    using Poseidon.Projects.Core.IDAL;

    /// <summary>
    /// 项目业务类
    /// </summary>
    public class ProjectBusiness : AbstractBusiness<Project>, IBaseBL<Project>
    {
        #region Constructor
        /// <summary>
        /// 项目业务类
        /// </summary>
        public ProjectBusiness()
        {
            this.baseDal = RepositoryFactory<IProjectRepository>.Instance;
        }
        #endregion //Constructor

        #region CRUD
        /// <summary>
        /// 添加项目
        /// </summary>
        /// <param name="entity">项目实体</param>
        /// <returns></returns>
        public override Project Create(Project entity)
        {
            entity.State = 0;
            entity.Status = 0;
            return base.Create(entity);
        }
        #endregion //CRUD
    }
}
