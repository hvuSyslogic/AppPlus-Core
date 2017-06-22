using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using System.Reflection;
using Microsoft.Practices.Unity;
using AutoMapper;
using Xx.His.Contract.Message;
using Xx.His.Contract.Service;
using Xx.His.Core;
using Serialize.Linq.Nodes;
using System.Linq.Expressions;
using Xx.His.Domain;
using System.ServiceModel;

namespace Xx.His.Service
{
    [GlobalExceptionHandlerBehaviourAttribute(typeof(GlobalExceptionHandler))]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)] 
    public abstract class QueryService<TEntity, TDTO> : Profile, IQueryService<TDTO>
        where TEntity: EntityBase, new()
        where TDTO : DtoBase, new()
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private bool disposed = false;

        #region Properties
        [Dependency]
        public virtual ICommandWrapper CommandWrapper
        {
            get { return IoCContainer.Instance.Resolve<ICommandWrapper>(); }
        }
        #endregion

        [Obsolete]
        protected override void Configure()
        {
            CreateMap<TEntity, TDTO>().ReverseMap();
        }

        public virtual TDTO Retrieve(params object[] keyValues)
        {
            if (keyValues == null)
                throw new HisException("KeyValues can not be null.");

            if (!keyValues.Any())
                throw new HisException("KeyValues can not be empty.");

            using (var command = CommandWrapper)
            {
                return command.Execute(uow =>
                {
                    TEntity entity = uow.Retrieve<TEntity>(keyValues);

                    return entity.MapTo<TDTO>();
                });
            }
        }

        public virtual IEnumerable<TDTO> Retrieve(ExpressionNode predicateExpressionNode)
        {
            var predicateExpression = (predicateExpressionNode == null)
                ? null : Mapper.Map<Expression<Func<TEntity, bool>>>(predicateExpressionNode.ToBooleanExpression<TDTO>());

            using (var command = CommandWrapper)
            {
                return command.Execute(uow =>
                {
                    IEnumerable<TEntity> entities = uow.Retrieve<TEntity>(predicateExpression);

                    return entities.MapTo<TDTO>();
                });
            }
        }

        public virtual IEnumerable<TDTO> Retrieve()
        {
            using (var command = CommandWrapper)
            {
                return command.Execute(uow =>
                {
                    IEnumerable<TEntity> entities = uow.Retrieve<TEntity>();

                    return entities.MapTo<TDTO>();
                });
            }
        }

        #region Dispose

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    if (CommandWrapper != null)
                    {
                        CommandWrapper.Dispose();
                    }
                }
            }

            this.disposed = true;
        }

        #endregion
    }
}
