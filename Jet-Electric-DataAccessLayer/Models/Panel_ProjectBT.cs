﻿namespace Jet_Electric_DataAccessLayer.Models
{
    public partial class Panel_ProjectBT
    {
        public int Quantity { get; set; }
        public int PanelID { get; set; }
        public int ProjectID { get; set; }

        public virtual Panel Panel { get; set; }
        public virtual Project Project { get; set; }
    }
}
