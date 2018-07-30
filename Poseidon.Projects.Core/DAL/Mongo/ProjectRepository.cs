using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Projects.Core.DAL.Mongo
{
    using MongoDB.Bson;
    using MongoDB.Driver;
    using Poseidon.Base.Framework;
    using Poseidon.Data;
    using Poseidon.Projects.Core.DL;
    using Poseidon.Projects.Core.IDAL;

    /// <summary>
    /// 项目数据访问类
    /// </summary>
    internal class ProjectRepository : AbstractDALMongo<Project>, IProjectRepository
    {
        #region Constructor
        /// <summary>
        /// 项目数据访问类
        /// </summary>
        public ProjectRepository()
        {
            base.Init("projects_project");
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// BsonDocument转实体对象
        /// </summary>
        /// <param name="doc">Bson文档</param>
        /// <returns></returns>
        protected override Project DocToEntity(BsonDocument doc)
        {
            Project entity = new Project();
            entity.Id = doc["_id"].ToString();
            entity.Name = doc["name"].ToString();
            entity.Number = doc["number"].ToString();
            entity.ShortName = doc["shortName"].ToString();
            entity.Type = doc["type"].ToInt32();
            entity.EstablishDate = doc["establishDate"].ToLocalTime();
            entity.Principal = doc["principal"].ToString();
            entity.State = doc["state"].ToInt32();
            entity.DatasetCode = doc["datasetCode"].ToString();
            entity.Remark = doc["remark"].ToString();
            entity.Status = doc["status"].ToInt32();

            return entity;
        }

        /// <summary>
        /// 实体对象转BsonDocument
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        protected override BsonDocument EntityToDoc(Project entity)
        {
            BsonDocument doc = new BsonDocument
            {
                { "name", entity.Name },
                { "number", entity.Number },
                { "shortName", entity.ShortName },
                { "type", entity.Type },
                { "establishDate", entity.EstablishDate },
                { "principal", entity.Principal },
                { "state", entity.State },
                { "datasetCode", entity.DatasetCode },
                { "remark", entity.Remark },
                { "status", entity.Status }
            };

            return doc;
        }
        #endregion //Function
    }
}
