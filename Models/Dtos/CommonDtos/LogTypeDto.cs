﻿using Models.Entities;

namespace Models.Dtos.CommonDtos
{
    public class LogTypeDto
    {
		public byte Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }

		public static implicit operator LogTypeDto(LogType v)
		{
			return new LogTypeDto
			{
				Id = v.Id,
				Name = v.Name,
				Description = v.Description
			};
		}
	}
}
