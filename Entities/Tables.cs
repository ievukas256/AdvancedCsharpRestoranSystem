﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedExamRestoran.Entities
{
    public class Tables
    {
        public int TableId { get; set; }
        public int TableSeats { get; set; }
        public bool IsFreeTable { get; set; }
        public Tables(int tableId, int tableSeats, bool isFreeTable)
        {
            TableId = tableId;
            TableSeats = tableSeats;
            IsFreeTable = isFreeTable;
        }
    }
}
