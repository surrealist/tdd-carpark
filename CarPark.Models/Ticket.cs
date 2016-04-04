using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark.Models {
  public class Ticket {

    public string PlateNo { get; set; }
    public DateTime DateIn { get; set; }
    public DateTime DateOut { get; set; }

    public decimal ParkingFee {
      get {
        TimeSpan ts = DateOut - DateIn;

        ts = ts.Add(TimeSpan.FromMinutes(-15));

        if (ts.TotalMinutes <= 0)
          return 0m;
        else if (ts.TotalHours <= 3.0)
          return 50m;
        else 
          return 50m + ((decimal)Math.Ceiling(ts.TotalHours - 3) * 30m);
        
      }
    }

  }
}
