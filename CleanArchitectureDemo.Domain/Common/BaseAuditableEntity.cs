﻿using CleanArchitectureDemo.Domain.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureDemo.Domain.Common
{
	internal class BaseAuditableEntity : BaseEntity, IAuditableEntity
	{
		public int? CreatedBy { get; set; }
		public int? UpdatedBy { get; set; }
		public DateTime? CreatedDate { get; set; }
		public DateTime? UpdatedDate { get; set; }
	}
}
