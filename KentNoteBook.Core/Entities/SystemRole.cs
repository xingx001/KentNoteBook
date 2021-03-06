﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using KentNoteBook.Core.Base;

namespace KentNoteBook.Core.Entities
{
	public class SystemRole : BaseEntity
	{
		[Key]
		public override Guid Id { get; set; }

		[MaxLength(50), Required]
		public string Name { get; set; }

		[MaxLength(500)]
		public string Description { get; set; }

		public bool IsActive { get; set; }

		public Status Status { get; set; }
		
		public List<UsersInRole> UsersInRoles { get; set; } = new List<UsersInRole>();
		public List<MenusInRole> MenusInRoles { get; set; } = new List<MenusInRole>();
	}

	public class UsersInRole
	{
		public Guid UserId { get; set; }
		public Guid RoleId { get; set; }

		public SystemUser User { get; set; }
		public SystemRole Role { get; set; }
	}

	public class MenusInRole
	{
		public Guid RoleId { get; set; }
		public Guid MenuId { get; set; }

		public SystemRole Role { get; set; }
		public SystemMenu Menu { get; set; }
	}
}
