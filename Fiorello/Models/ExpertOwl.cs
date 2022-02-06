using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello.Models
{
    public class ExpertOwl
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Decs { get; set; }
        public string Name { get; set; }
        public int PositionId { get; set; }
        public Position Position { get; set; }
        public int Order { get; set; }
        public string RightIcon { get; set; }
        public string LeftIcon { get; set; }
    }
}
