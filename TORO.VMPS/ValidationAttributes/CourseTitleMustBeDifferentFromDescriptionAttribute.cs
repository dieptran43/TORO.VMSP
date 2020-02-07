using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TORO.VMPS.Models;

namespace TORO.VMPS.ValidationAttributes
{
    public class CourseTitleMustBeDifferentFromDescriptionAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value,
            ValidationContext validationContext)
        {
            //var course = (CourseForManipulationDto)validationContext.ObjectInstance;
            var lsCourse = validationContext.ObjectInstance;
            var course = (CourseForCreationDto)((List<CourseForCreationDto>)lsCourse).FirstOrDefault();

            if (course.Title == course.Description)
            {
                return new ValidationResult(ErrorMessage,
                    new[] { nameof(CourseForManipulationDto) });
            }

            return ValidationResult.Success;
        }
    }
}
