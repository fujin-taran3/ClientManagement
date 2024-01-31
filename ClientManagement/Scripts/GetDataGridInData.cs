using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientManagement.Scripts
{
    public class GetDataGridInData
    {
        private DataGridView data = default;
        public GetDataGridInData(DataGridView view)
        {
            data = view;
        }

        public string[] GetCheckBox(int checkboxIndex,string columName)
        {
            List<DataGridViewRow> checkedRows = new List<DataGridViewRow>();
            List<string> getValues = new List<string>();

            foreach (DataGridViewRow row in data.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = row.Cells[checkboxIndex] as DataGridViewCheckBoxCell;

                // チェックボックスの列が存在し、チェックが入っている場合
                if (checkBoxCell != null && Convert.ToBoolean(checkBoxCell.Value))
                {
                    checkedRows.Add(row);
                }
            }
            
            // checkedRowsにはチェックが入っている行が含まれる
            foreach (DataGridViewRow checkedRow in checkedRows)
            {
                // ここで行に対する処理を行う
                getValues.Add(checkedRow.Cells[columName].Value.ToString());
            }

            return getValues.ToArray();
        }
    }
}
