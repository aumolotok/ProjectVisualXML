namespace XmlCheckingHelper
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Questions
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string QuestionCd { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string AcordNumber { get; set; }

        public int PositionInSection { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string AcordText { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Section { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string HelpText { get; set; }
    }
}
