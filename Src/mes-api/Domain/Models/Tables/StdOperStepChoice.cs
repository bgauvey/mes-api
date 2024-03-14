﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api.Models;

[Table("std_oper_step_choice")]
[Index("OperId", "StepNo", "ChoiceLabel", Name = "UIX_std_oper_step_choice", IsUnique = true)]
public partial class StdOperStepChoice
{
    [Column("oper_id")]
    [StringLength(40)]
    public string OperId { get; set; } = null!;

    [Column("step_no")]
    public int StepNo { get; set; }

    [Column("choice_no")]
    public int ChoiceNo { get; set; }

    [Column("choice_label")]
    [StringLength(40)]
    public string ChoiceLabel { get; set; } = null!;

    [Column("last_edit_comment")]
    [StringLength(254)]
    public string? LastEditComment { get; set; }

    [Column("last_edit_by")]
    [StringLength(40)]
    public string LastEditBy { get; set; } = null!;

    [Column("last_edit_at", TypeName = "datetime")]
    public DateTime LastEditAt { get; set; }

    [Key]
    [Column("row_id")]
    public int RowId { get; set; }

    [ForeignKey("OperId, StepNo")]
    [InverseProperty("StdOperStepChoices")]
    public virtual StdOperStep StdOperStep { get; set; } = null!;
}
