﻿using System.ComponentModel.DataAnnotations;
namespace FSite.Models.Data
{
    public class FaqCategoryItem
    {

        [Key]
        public long? Id { get; set; }
        [Display(Name = "_Title", ResourceType = typeof(Resources.Resource))]
        [StringLength(100, ErrorMessage = null, ErrorMessageResourceName = "StringLengthMessage", ErrorMessageResourceType = typeof(Resources.Resource))]
        public string Title { get; set; }
        [Display(Name = "_ImageUrl", ResourceType = typeof(Resources.Resource))]
        [Required(ErrorMessage = null, ErrorMessageResourceName = "StringEmptyMessage", ErrorMessageResourceType = typeof(Resources.Resource))]
        [StringLength(250, ErrorMessage = null, ErrorMessageResourceName = "StringLengthMessage", ErrorMessageResourceType = typeof(Resources.Resource))]
        public string ImageUrl { get; set; }
        [Display(Name = "_Index", ResourceType = typeof(Resources.Resource))]
        public int? Index { get; set; }
        [Display(Name = "_IsActive", ResourceType = typeof(Resources.Resource))]
        public bool? IsActive { get; set; }
        [Display(Name = "_FaqCategoryId", ResourceType = typeof(Resources.Resource))]
        public int? CategoryId { get; set; }
        public virtual FaqCategory Category { get; set; }
    }
}