using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureDemo.Domain.Common.Interfaces
{
	public interface IDomainEventDispatcher
	{
		Task DispatchAndClearEvent(IEnumerable<BaseEntity> entitiesWithEvents)
	}
}
