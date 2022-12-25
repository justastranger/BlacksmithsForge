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
    public partial class DictionaryEditor : Form
    {
        public Dictionary<string, object> Dictionary;
        private Type valueType;

        public DictionaryEditor(Dictionary<string, object> dictionaryToEdit)
        {
            InitializeComponent();
            Dictionary = dictionaryToEdit;
            valueType = dictionaryToEdit.GetType().GetGenericArguments()[1];
            UpdateDataGridView();
        }

        private void okayButton_Click(object sender, EventArgs e)
        {
            UpdateDictionary();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void UpdateDataGridView()
        {
            foreach (var pair in Dictionary)
            {
                dictionaryDataGridView.Rows.Add(pair.Key, pair.Value);
            }
        }

        private void UpdateDictionary()
        {
            Dictionary.Clear();

            foreach (DataGridViewRow row in dictionaryDataGridView.Rows)
            {
                if (row.Cells[0].Value?.ToString() != null && row.Cells[1].Value?.ToString() != null)
                {
                    // null checked above, idk why it is so damned sure there's a null reference possibility
                    
                    string key = row.Cells[0].Value.ToString();
                    object value;
                    if (valueType == typeof(string))
                    {
                        value = row.Cells[1].Value.ToString();
                    }
                    else if (valueType == typeof(int))
                    {
                        value = int.Parse(row.Cells[1].Value.ToString());
                    } else
                    {
                        value = row.Cells[1].Value;
                    }
                    

                    Dictionary.Add(key, value);
                }
            }
        }

        private void dictionaryDataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            UpdateDictionary();
        }

        private void dictionaryDataGridView_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (string.IsNullOrEmpty(dictionaryDataGridView.Rows[e.RowIndex].Cells[0].Value?.ToString()) &&
                string.IsNullOrEmpty(dictionaryDataGridView.Rows[e.RowIndex].Cells[1].Value?.ToString()))
            {
                UpdateDictionary();
            }
        }
    }
}
