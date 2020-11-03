﻿using SchoolManagement.Services.ViewModels.Exam;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagement.Services.ViewModels.Clasroom
{
    public class ClassroomViewModel
    {
        public int Id { get; set; }
        [Required]
        public int RoomNumber { get; set; }
        [Required]
        public int Capacity { get; set; }
        public List<string> Subjects { get; set; }
        public List<ExamViewModel> Exams { get; set; }
    }
}
