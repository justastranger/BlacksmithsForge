using BlacksmithsForge.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlacksmithsForge.Editors
{
    public partial class XTriggerInput : Form
    {
        public XTrigger xTrigger;

        public XTriggerInput(XTrigger xtrigger)
        {
            InitializeComponent();
            xTrigger = xtrigger;
        }

        public XTriggerInput() : this(new())
        {

        }


        private void idTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idTextBox.Text)) xTrigger.ID = "";
            else xTrigger.ID = idTextBox.Text;
        }

        private void chanceNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (chanceNumericUpDown.Value < 100) xTrigger.Chance = ((int)chanceNumericUpDown.Value);
            else xTrigger.Chance = null;
        }

        private void levelNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (chanceNumericUpDown.Value > 0) xTrigger.Chance = ((int)chanceNumericUpDown.Value);
            else xTrigger.Chance = null;
        }

        private void morphEffectTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // there's really no point in unsetting it since this isn't getting serialized as a quickspec
            xTrigger.MorphEffect = morphEffectTypeComboBox.SelectedText;
        }
    }
}
