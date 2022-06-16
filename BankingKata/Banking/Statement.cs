﻿using System;

namespace Banking
{
    public class Statement
    {
        public float Amount { get; set; }
        public DateTime Date { get; set; }

        public Statement(float amount, DateTime date)
        {
            Amount = amount;
            Date = date;
        }
    }
}