﻿using System;
namespace ReplicatingGMAIL.Controls
{

    public class MasterPageItem
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string IconSource { get; set; }

        public Type TargetType { get; set; }
    }
}