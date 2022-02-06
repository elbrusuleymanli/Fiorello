using Fiorello.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello.VM
{
    public class HomeVM
    {
      public  List<Slider> Sliders { get; set; }
      public  List<Expert> Experts { get; set; }
      public List<ExpertOwl> ExpertsOwl { get; set; }

    }
}
