﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace TypeScriptGenerator.Sample
{
    public partial class TaskExtended
    {
        public TaskExtended()
        {
            CreatedDate = DateTime.Now;
            ModifiedDate = DateTime.Now;
        }

        public int TaskId { get; set; }
        public string Browser { get; set; }
        public string Os { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public System.Byte[] RowVersion { get; set; }

        public virtual Task Task { get; set; }
    }
}