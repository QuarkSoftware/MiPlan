//******************************************************************************************************
//  Install.cs - Gbtc
//
//  Copyright � 2016, Grid Protection Alliance.  All Rights Reserved.
//
//  Licensed to the Grid Protection Alliance (GPA) under one or more contributor license agreements. See
//  the NOTICE file distributed with this work for additional information regarding copyright ownership.
//  The GPA licenses this file to you under the MIT License (MIT), the "License"; you may
//  not use this file except in compliance with the License. You may obtain a copy of the License at:
//
//      http://opensource.org/licenses/MIT
//
//  Unless agreed to in writing, the subject software distributed under the License is distributed on an
//  "AS-IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. Refer to the
//  License for the specific language governing permissions and limitations.
//
//  Code Modification History:
//  ----------------------------------------------------------------------------------------------------
//  02/27/2016 - J. Ritchie Carroll
//       Generated original version of source code.
//
//******************************************************************************************************

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GSF.Data.Model;

namespace MiPlan.Models
{
    /// <summary>
    /// Model for MiPlan.Install table.
    /// </summary>
    [PrimaryLabel("Summary")]
    public class Install
    {
        [PrimaryKey(true)]
        public int ID { get; set; }

        [Label("Patch")]
        public int PatchID { get; set; }

        public string Summary { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CompletedOn { get; set; }

        [Label("Completed Notes")]
        public string CompletedNotes { get; set; }

        public DateTime CreatedOn { get; set; }

        public Guid CreatedByID { get; set; }

        public DateTime UpdatedOn { get; set; }

        public Guid UpdatedByID { get; set; }
    }
}
