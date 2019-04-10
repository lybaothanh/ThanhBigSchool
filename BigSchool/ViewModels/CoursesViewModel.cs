using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BigSchool.Models;

namespace BigSchool.ViewModels
{
    public class CoursesViewModel
    {
        public IQueryable<Course> UpCommingCourses { get; internal set; }
    }
}