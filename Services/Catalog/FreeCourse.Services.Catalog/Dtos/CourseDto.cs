﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeCourse.Services.Catalog.Dtos
{
    internal class CourseDto
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string UserId { get; set; }

        public string Picture { get; set; }

        public DateTime CreateDate { get; set; }

        public FeatureDto Feature { get; set; }

        // For relationship with Category
        public string CategoryId { get; set; }

        // Only for code side
        public CategoryDto Category { get; set; }
    }
}
