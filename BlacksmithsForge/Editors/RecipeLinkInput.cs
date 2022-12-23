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
    public partial class RecipeLinkInput : Form
    {
        public RecipeLink RecipeLink;

        public RecipeLinkInput(RecipeLink recipeLink)
        {
            InitializeComponent();
            RecipeLink = recipeLink;
        }

        public RecipeLinkInput()
        {
            InitializeComponent();
            RecipeLink = new();
        }

        private void additionalCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
