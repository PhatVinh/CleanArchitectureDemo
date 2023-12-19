using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureDemo.Domain.Common.Interfaces
{
	public interface IAuditableEntity : IEntity
	{
		int? CreatedBy { get; set; }
		int? UpdatedBy { get; set; }
		DateTime? CreatedDate { get; set; }
		DateTime? UpdatedDate { get; set; }
	}
}
