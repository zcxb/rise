﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Rise.Auditing
{
    public interface IModificationAuditedObject<TUserId> : IHasModificationTime
        where TUserId : struct
    {
        TUserId? LastModifierId { get; set; }
    }
}