﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC_EF_Start.Models
{
  public class Company
  {
    [Key] // decoration indicates primary key for line below
    public string symbol { get; set; }
    public string name { get; set; }
    public string date { get; set; }
    public bool isEnabled { get; set; }
    public string type { get; set; }
    public string iexId { get; set; }
    public List<Quote> Quotes { get; set; }  // list indicates table relationship, 1 company has many quotes
  }

  public class Quote
  {
    public int QuoteId { get; set; }
    public string date { get; set; }
    public float open { get; set; }
    public float high { get; set; }
    public float low { get; set; }
    public float close { get; set; }
    public int volume { get; set; }
    public int unadjustedVolume { get; set; }
    public float change { get; set; }
    public float changePercent { get; set; }
    public float vwap { get; set; }
    public string label { get; set; }
    public float changeOverTime { get; set; }
    public string symbol { get; set; }
  }

  public class ChartRoot
  {
    public Quote[] chart { get; set; }
  }
}