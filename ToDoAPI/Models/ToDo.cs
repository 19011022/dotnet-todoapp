using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ToDoAPI.Models
{
    public class ToDo
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-ddTHH:mm:ss}")]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Title is required.")]
        public bool IsCompleted { get; set; }

        public string Detail { get; set; }

        [EnumDataType(typeof(Priority))]
        public Priority? Priority { get; set; }

        public string Username { get; set; }
    }

    public enum Priority
    {
        Low,
        Medium,
        High
    }
}